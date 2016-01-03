using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Reader_Layer
{
    public class ShareIndexReader
    {
        // https://s3.amazonaws.com/quandl-static-content/Ticker+CSV%27s/Indicies/FTSE100.csv
        public static IEnumerable<string> GetSymbols(string url)
        {
            string file = string.Empty;

            using (WebClient webClient = new WebClient())
            {
                file = webClient.DownloadString(url);
            }

            var rows = file.Split('\r');
            if (rows.Length == 0)
                return new string[0];

            var fields = rows[0].Split(',');
            if (fields.Length != 3)
                throw new ApplicationException(string.Format("CSV share component index file download does not have the correct number of columns currently has {1} expected 3", fields.Length));

            return rows.Skip(1).Select(f => f.Split(new[] {','}, 2)[0] + ".L").ToList();
        }
    }
}
