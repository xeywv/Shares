using Reader_Layer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared;

namespace Processors
{
    public enum ResultState
    {
        FailedFindingSellPoint,
        OK
    }

    public struct Result
    {
        public Price buy;
        public Price sell;
        public ResultState state;
    }

    public struct SimpleSearchSettings : ICloneable
    {
        public int riseSearchPeriodInDays;
        public int fallSearchPeriodInDays;
        public decimal requiredChangeRate;
        public int numerOfRepeats;

        public object Clone()
        {
            return MemberwiseClone();
        }
    }

    public class SimpleSearch
    {
        public List<List<Result>> Results { get; private set; }

        public void Process(Price[] shareData, SimpleSearchSettings settings)
        {
            this.Results = new List<List<Result>>();
            int count = shareData.Count();
            Price? lastSellPoint = null;

            List<Result> currentRun = new List<Result>();
            int buyPointIndex = 0;
            decimal? phase2Slope = null, phase2Intercept = null;
            while (buyPointIndex < count)
            {
                if (currentRun.Count < settings.numerOfRepeats)
                {
                    var buyPoint = shareData[buyPointIndex];
                    var sellPoint = buyPoint;

                    bool found = false;
                    for (int sellPointIndex = buyPointIndex + 1; sellPointIndex < count && (sellPoint.date - buyPoint.date).TotalDays < settings.riseSearchPeriodInDays; sellPointIndex++)
                    {
                        sellPoint = shareData[sellPointIndex];

                        if (((sellPoint.closePrice - buyPoint.closePrice) * 100 / buyPoint.closePrice) > settings.requiredChangeRate)
                        {
                            currentRun.Add(new Result() { buy = buyPoint, sell = sellPoint, state = ResultState.OK });
                            lastSellPoint = sellPoint;
                            buyPointIndex = sellPointIndex + 1;
                            phase2Slope = phase2Intercept = null;
                            found = true;
                            break;
                        }
                    }

                    bool withinFallBuyPeriod = lastSellPoint == null || (buyPoint.date - lastSellPoint.Value.date).TotalDays < settings.fallSearchPeriodInDays;

                    if (!found && !withinFallBuyPeriod)
                    {
                        currentRun.Clear();
                        lastSellPoint = null;
                    }
                }
                else
                {
                    bool foundBuyPoint = false, foundSellPoint = false;
                    do
                    {
                        double[] x = currentRun.Select(c => (double)c.buy.date.Ticks).ToArray();
                        double[] y = currentRun.Select(c => (double)c.buy.closePrice).ToArray();
                        double slope, intercept;
                        MathExtension.GenerateLinearBestFit(x, y, out slope, out intercept);
                        phase2Slope = (decimal)slope; phase2Intercept = (decimal)intercept;

                        foundBuyPoint = foundSellPoint = false;
                        Price buyPoint, sellPoint;
                        do
                        {
                            buyPoint = shareData[buyPointIndex++];
                            foundBuyPoint = (buyPoint.closePrice <= (phase2Slope * buyPoint.date.Ticks + phase2Intercept));
                        } while (buyPointIndex < count-1 && !foundBuyPoint && (buyPoint.date - lastSellPoint.Value.date).TotalDays < settings.fallSearchPeriodInDays);

                        sellPoint = buyPoint;
                        if (foundBuyPoint)
                        {
                            for (int sellPointIndex = buyPointIndex; sellPointIndex < count && !foundSellPoint && (sellPoint.date - buyPoint.date).TotalDays < settings.riseSearchPeriodInDays; sellPointIndex++)
                            {
                                sellPoint = shareData[sellPointIndex];

                                if (((sellPoint.closePrice - buyPoint.closePrice) * 100 / buyPoint.closePrice) > settings.requiredChangeRate)
                                {
                                    foundSellPoint = true;
                                    buyPointIndex = sellPointIndex;
                                    break;
                                }
                            }

                            currentRun.Add(new Result() { buy = buyPoint, sell = sellPoint, state = foundSellPoint ? ResultState.OK : ResultState.FailedFindingSellPoint });
                        }

                    } while (foundSellPoint);

                    if (currentRun.Count >= settings.numerOfRepeats)
                        Results.Add(currentRun);
                    currentRun = new List<Result>();
                }

                buyPointIndex++;
            }
        }
    }
}
