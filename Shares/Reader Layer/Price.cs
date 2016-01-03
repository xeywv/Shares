using System;
using System.Collections.Generic;
using System.Linq;
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

    public static class PriceEnumerationExtension
    {
        public static XDate[] ToXArray(this IEnumerable<Price> list)
        {
            DateTime startDate = list.First().date;
            return list.Select(d => (startDate - d.date).TotalDays).ToArray();
        }

        public static double[] ToYArray(this IEnumerable<Price> list)
        {
            return list.Select(d => (double)d.closePrice).ToArray();
        }
    }
}
