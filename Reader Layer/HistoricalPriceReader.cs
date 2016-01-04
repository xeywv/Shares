using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Reader_Layer
{
    public struct Price
    {
        public DateTime date;
        public decimal openPrice;
        public decimal highPrice;
        public decimal lowPrice;
        public decimal closePrice;
        public long volume;
        public decimal adjClose;
    }


    public class HistoricalPriceReader
    {
        public static IEnumerable<Price> Get(string symbol)
        {
            List<Price> result = new List<Price>();
            DateTime now = DateTime.Now;
            string url = string.Format("http://real-chart.finance.yahoo.com/table.csv?s={0}&d={2}&e={1}&f={3}&g=d&a=1&b=1&c=1900&ignore=.csv", symbol, now.Day, now.Month - 1, now.Year);
            string file = string.Empty;

            using (WebClient webClient = new WebClient())
            {
                file = webClient.DownloadString(url);
            }

            var rows = file.Split('\n');
            if (rows.Length == 0)
                return new Price[0];

            var fields = rows[0].Split(',');
            if (fields.Length != 7)
                throw new ApplicationException(string.Format("CSV file (for symbol {0}) download from Yahoo does not have the correct number of columns currently has {1} expected 7", symbol, fields.Length));

            if (fields[0] != "Date")
                throw new ApplicationException(string.Format("CSV file (for symbol {0}) has invalid 0 column name has {1} expected Date", symbol, fields[0]));
            if (fields[1] != "Open")
                throw new ApplicationException(string.Format("CSV file (for symbol {0}) has invalid 1 column name has {1} expected Open", symbol, fields[0]));
            if (fields[2] != "High")
                throw new ApplicationException(string.Format("CSV file (for symbol {0}) has invalid 2 column name has {1} expected High", symbol, fields[0]));
            if (fields[3] != "Low")
                throw new ApplicationException(string.Format("CSV file (for symbol {0}) has invalid 3 column name has {1} expected Low", symbol, fields[0]));
            if (fields[4] != "Close")
                throw new ApplicationException(string.Format("CSV file (for symbol {0}) has invalid 4 column name has {1} expected Close", symbol, fields[0]));
            if (fields[5] != "Volume")
                throw new ApplicationException(string.Format("CSV file (for symbol {0}) has invalid 5 column name has {1} expected Volume", symbol, fields[0]));
            if (!fields[6].StartsWith("Adj Close"))
                throw new ApplicationException(string.Format("CSV file (for symbol {0}) has invalid 6 column name has {1} expected Adj Close", symbol, fields[0]));

            foreach (var row in rows.Skip(1))
            {
                try
                {
                    fields = row.Split(',');

                    var price = new Price()
                    {
                        date = DateTime.ParseExact(fields[0], "yyyy-MM-dd", CultureInfo.CurrentCulture),
                        openPrice = decimal.Parse(fields[1]),
                        highPrice = decimal.Parse(fields[2]),
                        lowPrice = decimal.Parse(fields[3]),
                        closePrice = decimal.Parse(fields[4]),
                        //volume = long.Parse(fields[5]),
                        //adjClose = decimal.Parse(fields[6])
                    };

                    result.Add(price);
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine("HistoricalPricwReader.Get failed reading line {0} error is {1}", row, ex.Message);
                }
            }

            result.Reverse();

            return result;
        }

        public static IEnumerable<SplitEvent> GetSplitEvents(string symbol, DateTime from)
        {
            DateTime now = DateTime.Now;
            string url = string.Format("http://finance.yahoo.com/q/hp?s={0}&a={1}&b={4}&c={6}&d={2}&e={5}&f={3}&g=v", symbol, now.Day, now.Month - 1, now.Year, from.Day, from.Month - 1, from.Year);
            List<SplitEvent> splits = new List<SplitEvent>();

            using (WebBrowserAdv webBrowser = new WebBrowserAdv())
            {
                HtmlAgilityPack.HtmlNodeCollection splitNodes = null;
                int tries = 0;
                bool found = false;

                while (tries < 3 && !found)
                {
                    try
                    {
                        if (!webBrowser.Navigate(5000, url))
                            throw new ApplicationException("Failed navigating to " + url);

                        splitNodes = webBrowser.GetHtmlAgilityPackDocument().DocumentNode.SelectNodes(".//td[contains(text(),'Stock Split')]");
                        found = webBrowser.GetHtmlAgilityPackDocument().DocumentNode.SelectNodes(".//th[text()='Prices']") != null;
                    }
                    catch (Exception ex)
                    {
                        if (tries++ >= 3)
                            throw ex;
                        System.Threading.Thread.Sleep(1000);
                    }
                }

                if (splitNodes != null)
                { 
                    foreach (var td in splitNodes)
                    {
                        try
                        {
                            var dateStr = td.ParentNode.ChildNodes[0].InnerText;
                            var ratio = td.InnerText.Replace("\n", "").Replace(" ", "").Split(new[] { "Stock" }, StringSplitOptions.RemoveEmptyEntries)[0].Split(':');
                            var sharesBefore = ratio[0];
                            var sharesAfter = ratio[1];

                            splits.Add(new SplitEvent(DateTime.Parse(dateStr), int.Parse(sharesBefore), int.Parse(sharesAfter)));
                        }
                        catch (Exception ex)
                        {
                            throw new ApplicationException("Failed reading split", ex);
                        }                    
                    }
                }
            }

            splits.Add(new SplitEvent(DateTime.MaxValue, 1, 1));
            splits.CalculateCumalitveAdjustment();

            return splits.OrderBy(d => d.date);
        }

        public static IEnumerable<Price> Convert(IEnumerable<Price> shareData, IEnumerable<SplitEvent> splits)
        {
            int cumaltiveUpdateIndex = 0;
            decimal cumaltiveAdj = splits.First().cumalitveAdjustment;

            foreach (var d in shareData.Skip(1))
            {
                if (splits.ElementAt(cumaltiveUpdateIndex).date <= d.date)
                {
                    cumaltiveUpdateIndex++;
                    cumaltiveAdj = splits.ElementAt(cumaltiveUpdateIndex).cumalitveAdjustment;
                }

                yield return new Price()
                {
                    date = d.date,
                    openPrice = d.openPrice * cumaltiveAdj,
                    highPrice = d.highPrice * cumaltiveAdj,
                    lowPrice = d.lowPrice * cumaltiveAdj,
                    closePrice = d.closePrice * cumaltiveAdj,
                    //volume = long.Parse(fields[5]),
                    //adjClose = decimal.Parse(fields[6])
                };
            }
        }
    }
}
