using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Reader_Layer
{
    public class SplitEvent
    {
        public DateTime date;
        public int originalShares;
        public int newShareAllocation;
        public decimal cumalitveAdjustment;

        public SplitEvent(DateTime date, int originalShares, int newShareAllocation)
        {
            this.date = date;
            this.originalShares = originalShares;
            this.newShareAllocation = newShareAllocation;
        }
    }


    //public class SplitEventLookup : Dictionary<string,List<SplitEvent>>
    //{ 
    //    public List<SplitEvent> Find(string symbol)
    //    {
    //        List<SplitEvent> splitEvents;
    //        if (!this.TryGetValue(symbol, out splitEvents))
    //            splitEvents = new List<SplitEvent>();
    //        return splitEvents;
    //    }

    //    public void Save(string file)
    //    {
    //        if (File.Exists(file) && File.GetAttributes(file).HasFlag(FileAttributes.ReadOnly))
    //            throw new ApplicationException("File " + file + " is read only");

    //        using (var stream = File.Create(file))
    //        {
    //            DataContractJsonSerializer serializer = new DataContractJsonSerializer(this.GetType());
    //            serializer.WriteObject(stream, this);
    //        }
    //    }

    //    public static SplitEventLookup Read(string file)
    //    {
    //        if (!File.Exists(file))
    //            throw new ApplicationException("Failed to find file " + file);

    //        using (var stream = File.OpenRead(file))
    //        {
    //            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(SplitEventLookup));
    //            return (serializer.ReadObject(stream) as SplitEventLookup);
    //        }
    //    }

    //    public static SplitEventLookup Convert(string text)
    //    {
    //        var data = JsonConvert.DeserializeObject<Dictionary<string, List<SplitEvent>>>(text);

    //        SplitEventLookup splits = new SplitEventLookup();
    //        foreach (var d in data)
    //            splits.Add(d.Key, d.Value);
    //        return splits;
    //    }
    //}

    public static class SplitEnumerationExtension
    {
        public static void CalculateCumalitveAdjustment(this IEnumerable<SplitEvent> value)
        {
            decimal cumalitveAdjustment = 1;
            var list = value.OrderByDescending(d => d.date).ToList();
            for (int c = 0; c < list.Count; c++)
            {
                cumalitveAdjustment = cumalitveAdjustment * (list[c].newShareAllocation / (decimal)list[c].originalShares);
                list[c].cumalitveAdjustment = cumalitveAdjustment;
            }
        }
    }
}
