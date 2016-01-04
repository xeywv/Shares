using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;
using Reader_Layer;
using Processors;
using System.IO;
using Newtonsoft.Json;

namespace Shares
{
    public partial class Form1 : Form
    {
        private enum GraphMarkerType
        {
            Split,
            SimpleSarch
        }

        static readonly Color GraphColour_Normanlised = Color.Blue;
        static readonly Color GraphColour_Raw         = Color.Green;
        static readonly Color GraphColour_Splits      = Color.Blue;

        Dictionary<string,List<Price>> shareData = new Dictionary<string, List<Price>>();
        Dictionary<string, List<SplitEvent>> splitData = new Dictionary<string, List<SplitEvent>>();
        SimpleSearchSettings simpleSearchSettings = new SimpleSearchSettings();
        IEnumerable<string> symbols;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var path = Path.Combine(Directory.GetCurrentDirectory(), "settings.txt");
            using (var file = File.OpenText(path))
            {
                this.simpleSearchSettings= JsonConvert.DeserializeObject<SimpleSearchSettings>(file.ReadLine());

                file.Close();
            }

            tbAllSharesFallSearchPeriod.Text = tbFallSearchPeriod.Text = simpleSearchSettings.fallSearchPeriodInDays.ToString();
            tbAllSharesRiseSearchPeriod.Text = tbRiseSearchPeriod.Text = simpleSearchSettings.riseSearchPeriodInDays.ToString();
            tbAllSharesRateChange.Text       = tbRateChange.Text       = simpleSearchSettings.requiredChangeRate.ToString();
            tbAllSharesRepeats.Text          = tbRepeats.Text          = simpleSearchSettings.numerOfRepeats.ToString();

            this.symbols = ShareIndexReader.GetSymbols("https://s3.amazonaws.com/quandl-static-content/Ticker+CSV%27s/Indicies/FTSE100.csv");
            this.cbSelectSymbol.Items.AddRange(symbols.ToArray());
            this.cbSelectSymbol.SelectedIndex = symbols.ToList().IndexOf("VOD.L");

            this.cbGraphDisplay.SelectedIndex = 0;

            zedGraphControl1.GraphPane.Title.IsVisible = false;

            string symbol = this.cbSelectSymbol.SelectedItem as string;
            DisplayGraph(this.GetShareData(symbol), this.GetSplitData(symbol));
            PopulateSplitListView(this.GetSplitData(symbol));
        }   

        private void DisplayGraph(IEnumerable<Price> data, IEnumerable<SplitEvent> splits)
        {
            zedGraphControl1.GraphPane.CurveList.Clear();
            zedGraphControl1.GraphPane.GraphObjList.RemoveAll(s => (GraphMarkerType)s.Tag == GraphMarkerType.Split);

            if (cbGraphDisplay.SelectedIndex != -1 && cbGraphDisplay.SelectedItem.ToString().Contains("Raw"))
            {
                LineItem shareLine = zedGraphControl1.GraphPane.AddCurve("Raw", 
                                                                          data.Select(d => (double)new XDate(d.date)).ToArray(), 
                                                                          data.Select(d => (double)d.closePrice).ToArray(), 
                                                                          GraphColour_Raw);
                shareLine.Symbol.Type = SymbolType.None;
            }
            if (cbGraphDisplay.SelectedIndex != -1 && cbGraphDisplay.SelectedItem.ToString().Contains("Normalised"))
            {
                LineItem shareLine = zedGraphControl1.GraphPane.AddCurve("Normalised",
                                                                          data.Select(d => (double)new XDate(d.date)).ToArray(),
                                                                          HistoricalPriceReader.Convert(data, splits).Select(d => (double)d.closePrice).ToArray(),
                                                                          GraphColour_Normanlised);
                shareLine.Symbol.Type = SymbolType.None;
            }

            zedGraphControl1.GraphPane.XAxis.Title.Text = "Date";
            zedGraphControl1.GraphPane.XAxis.Type = AxisType.Date;
            zedGraphControl1.GraphPane.XAxis.Scale.Format = "dd-MM-yy";
            zedGraphControl1.GraphPane.XAxis.Scale.MajorUnit = DateUnit.Year;
            zedGraphControl1.GraphPane.XAxis.Scale.MajorStep = 1;
            zedGraphControl1.GraphPane.XAxis.Scale.MinorUnit = DateUnit.Day;
            zedGraphControl1.GraphPane.XAxis.Scale.MinorStep = 1;
            zedGraphControl1.GraphPane.XAxis.Scale.Min = (double)new XDate(data.First().date);
            zedGraphControl1.GraphPane.XAxis.Scale.Max = (double)new XDate(data.Last().date);
            zedGraphControl1.GraphPane.YAxis.Title.Text = "Close Price";
            zedGraphControl1.AxisChange();

            if (cbSplitsShowOnGraph.Checked)
            {
                foreach (var s in splits)
                    AddMarker(zedGraphControl1, s.date, GraphColour_Splits, GraphMarkerType.Split);
            }

            zedGraphControl1.Invalidate();
        }

        private void ClearGraph()
        {
            zedGraphControl1.GraphPane.CurveList.Clear();
            zedGraphControl1.GraphPane.GraphObjList.RemoveAll(s => true);
        }

        private void AddRegion(double x1, double x2, Color lightBlue)
        {
            BoxObj box = new BoxObj(x1, 0, x2 - x1, 80, Color.LightGreen, Color.LightGreen);
            box.Location.CoordinateFrame = CoordType.AxisXYScale;
            box.IsVisible = true;
            box.ZOrder = ZOrder.A_InFront;//.D_BehindAxis;//.E_BehindAxis;
            zedGraphControl1.GraphPane.GraphObjList.Add(box);
        }

        private void AddMarker(ZedGraphControl gc, DateTime date, Color color, GraphMarkerType markerType)
        {
            var ymax = gc.GraphPane.YAxis.Scale.Max;
            LineObj line = new LineObj(color, (double)new XDate(date), (double)0, (double)new XDate(date), ymax);
            line.Tag = markerType;
            line.ZOrder = ZOrder.E_BehindCurves;
            gc.GraphPane.GraphObjList.Add(line);
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            zedGraphControl1.GraphPane.GraphObjList.RemoveAll(t => t is LineObj);

            SimpleSearchSettings settings = new SimpleSearchSettings();
            settings.fallSearchPeriodInDays = int.Parse(tbFallSearchPeriod.Text);
            settings.riseSearchPeriodInDays = int.Parse(tbRiseSearchPeriod.Text);
            settings.requiredChangeRate = decimal.Parse(tbRateChange.Text);
            settings.numerOfRepeats = int.Parse(tbRepeats.Text);

            string symbol = cbSelectSymbol.SelectedItem as string;
            IEnumerable<Price> data = this.GetShareData(symbol);
            IEnumerable<SplitEvent> splitData = this.GetSplitData(symbol);
            data = HistoricalPriceReader.Convert(data, splitData).ToArray();

            SimpleSearch processor = new SimpleSearch();
            processor.Process(data.ToArray(), settings);

            DisplaySimpleSearchResults(processor.Results);
        }

        private void DisplaySimpleSearchResults(List<List<Result>> results)
        {
            lvSimpleSearchResults.Items.Clear();

            for (int r = 0; r < results.Count; r++)
            {
                var items = results[r];
                for (int i = 0; i < items.Count; i++)
                {
                    if (i == (items.Count - 1) && items[i].state == ResultState.FailedFindingSellPoint)
                        AddMarker(zedGraphControl1, items[i].buy.date, Color.Red, GraphMarkerType.SimpleSarch);
                    else if (i == 0)
                        AddMarker(zedGraphControl1, items[i].buy.date, Color.DarkBlue, GraphMarkerType.SimpleSarch);
                    else
                        AddMarker(zedGraphControl1, items[i].buy.date, Color.Blue, GraphMarkerType.SimpleSarch);

                    if (items[i].state == ResultState.OK)
                    {
                        if (i == (items.Count - 1))
                            AddMarker(zedGraphControl1, items[i].sell.date, Color.LightGreen, GraphMarkerType.SimpleSarch);
                        else
                            AddMarker(zedGraphControl1, items[i].sell.date, Color.Green, GraphMarkerType.SimpleSarch);
                    }
                }

                ListViewItem item = new ListViewItem();
                item.Text = items.First().buy.date.ToString("dd/MM/yy");
                item.SubItems.Add(items.Last().buy.date.ToString("dd/MM/yy"));
                item.SubItems.Add(items.Count(c => c.state == ResultState.OK).ToString());
                item.SubItems.Add(items.Any(c => c.state == ResultState.FailedFindingSellPoint) ? "Y" : "N");
                lvSimpleSearchResults.Items.Add(item);
            }

            zedGraphControl1.Invalidate();
        }

        private void PopulateSplitListView(IEnumerable<SplitEvent> splits)
        {
            lvSplits.Items.Clear();
            lvSplits.BeginUpdate();
            foreach (var s in splits)
            {
                ListViewItem items = new ListViewItem();
                items.Text = s.date.ToString("dd/MM/yyyy");
                items.SubItems.Add(s.originalShares.ToString());
                items.SubItems.Add(s.newShareAllocation.ToString());
                items.SubItems.Add(s.cumalitveAdjustment.ToString("0.0000"));
                items.Tag = s;
                lvSplits.Items.Add(items);
            }
            lvSplits.EndUpdate();
        }

        private void btSaveSimpleSearchSettings_Click(object sender, EventArgs e)
        {
            this.simpleSearchSettings.fallSearchPeriodInDays = int.Parse(tbFallSearchPeriod.Text);
            this.simpleSearchSettings.riseSearchPeriodInDays = int.Parse(tbRiseSearchPeriod.Text);
            this.simpleSearchSettings.requiredChangeRate = decimal.Parse(tbRateChange.Text);
            this.simpleSearchSettings.numerOfRepeats = int.Parse(tbRepeats.Text);

            this.SaveSettings();
        }

        private void SaveSettings()
        {
            var path = Path.Combine(Directory.GetCurrentDirectory(), "Splits.txt");
            using (var file = File.CreateText(path))
            {
                file.WriteLine(JsonConvert.SerializeObject(this.simpleSearchSettings));

                file.Close();
            }
        }

        private void btnSimpleSearchGentics_Click(object sender, EventArgs e)
        {
            SimpleSearchSettings currentSettings = new SimpleSearchSettings(), bestSettings;
            int currentFailedSells, bestFailedSells;
            int currentOkSells, bestOkSells;
            Random rnd = new Random();
            string symbol = cbSelectSymbol.SelectedItem as string;
            Price[] data = HistoricalPriceReader.Convert(this.GetShareData(symbol), this.GetSplitData(symbol)).ToArray();

            bestSettings = this.simpleSearchSettings;

            SimpleSearch search = new SimpleSearch();
            search.Process(data, this.simpleSearchSettings);
            var results = search.Results;

            bestFailedSells = results.Count(r => r.Last().state == ResultState.FailedFindingSellPoint);
            bestOkSells     = results.Count(r => r.Last().state == ResultState.OK);

            for (int c = 365; c > 0; c--)
            {
                currentSettings.fallSearchPeriodInDays = rnd.Next(1, c);
                currentSettings.riseSearchPeriodInDays = rnd.Next(1, c);
                currentSettings.requiredChangeRate     = rnd.Next(1, c);
                currentSettings.numerOfRepeats         = this.simpleSearchSettings.numerOfRepeats;

                search.Process(data, currentSettings);
                results = search.Results;

                currentFailedSells = results.Count(r => r.Last().state == ResultState.FailedFindingSellPoint);
                currentOkSells     = results.Count(r => r.Last().state == ResultState.OK);

                if (currentOkSells > 0 && (currentFailedSells < bestFailedSells || (currentFailedSells == bestFailedSells && currentOkSells > bestOkSells)))
                {
                    bestSettings = (SimpleSearchSettings)currentSettings.Clone();
                    bestFailedSells = currentFailedSells;
                    bestOkSells = currentOkSells;
                }
            }

            tbFallSearchPeriod.Text = bestSettings.fallSearchPeriodInDays.ToString();
            tbRiseSearchPeriod.Text = bestSettings.riseSearchPeriodInDays.ToString();
            tbRateChange.Text = bestSettings.requiredChangeRate.ToString();
            tbRepeats.Text = bestSettings.numerOfRepeats.ToString();

            search.Process(data, bestSettings);
            DisplaySimpleSearchResults(search.Results);
        }

        private void btnAllSharesGo_Click(object sender, EventArgs e)
        {
            foreach (var s in this.symbols)
            {
                Price[] data = HistoricalPriceReader.Convert(this.GetShareData(s), this.GetSplitData(s)).ToArray();

                SimpleSearch search = new SimpleSearch();
                search.Process(data, this.simpleSearchSettings);
                var results = search.Results;
            }
        }

        private void cbSelectSymbol_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            this.Enabled = false;
            string symbol = cbSelectSymbol.SelectedItem as string;
            ClearGraph();
            DisplayGraph(this.GetShareData(symbol), this.GetSplitData(symbol));
            PopulateSplitListView(this.GetSplitData(symbol));
            this.Enabled = true;
            Cursor.Current = Cursors.Default;
        }

        private void CbGraphDisplay_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            string symbol = cbSelectSymbol.SelectedItem as string;
            DisplayGraph(this.GetShareData(symbol), this.GetSplitData(symbol));
        }

        private void cbSplitsShowOnGraph_Click(object sender, EventArgs e)
        {
            string symbol = cbSelectSymbol.SelectedItem as string;
            DisplayGraph(this.GetShareData(symbol), this.GetSplitData(symbol));
        }

        private IEnumerable<Price> GetShareData(string symbol)
        {
            List<Price> data;
            if (!this.shareData.TryGetValue(symbol, out data))
            {
                data = HistoricalPriceReader.Get(symbol).ToList();
                this.shareData[symbol] = data;
            }
            return data;
        }

        private IEnumerable<SplitEvent> GetSplitData(string symbol)
        {
            List<SplitEvent> data;
            if (!this.splitData.TryGetValue(symbol, out data))
            {
                data = HistoricalPriceReader.GetSplitEvents(symbol, this.GetShareData(symbol).Select(s => s.date).Min()).ToList();
                this.splitData[symbol] = data;
            }
            return data;
        }
    }
}
