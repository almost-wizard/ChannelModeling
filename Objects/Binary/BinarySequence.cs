using ChannelModeling.Objects.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChannelModeling.Objects
{
    public class BinarySequence<T> where T : IBinaryData
    {
        private static readonly string INTERVAL_SEQUENCE_DEVIDER = ".";

        public List<T> Value { get; }

        public int ErrorsCount { get; }

        public double ErrorsRate { get { return (double)ErrorsCount / Value.Count; } }


        public BinarySequence(List<T> value)
        {
            Value = value;
            ErrorsCount = GetErrorsCount(value);
        }

        private int GetErrorsCount(List<T> value)
        {
            return value.Where(x => x.HasError).Count();
        }

        public String ToIntervalString()
        {
            StringBuilder result = new StringBuilder();

            bool inErrorFreeInterval = false;
            int errosFreeIntervalStart = -1;

            for (int i = 0; i < Value.Count; i++)
            {

                if (!Value[i].HasError)
                {
                    if (!inErrorFreeInterval)
                    {
                        inErrorFreeInterval = true;
                        errosFreeIntervalStart = i;
                    }
                }
                else
                {
                    if (inErrorFreeInterval)
                    {
                        if (i + 1 != Value.Count)
                        {
                            result.Append(String.Format("{0}{1}", i - errosFreeIntervalStart, INTERVAL_SEQUENCE_DEVIDER));
                        }
                        else
                        {
                            result.Append(i - errosFreeIntervalStart);
                        }
                        inErrorFreeInterval = false;
                    }
                    else
                    {
                        if (i + 2 < Value.Count)
                        {
                            result.Append(String.Format("0{0}", INTERVAL_SEQUENCE_DEVIDER));
                        }
                        else if (i + 1 != Value.Count)
                        {
                            result.Append(0);
                        }
                    }
                }
            }

            if (inErrorFreeInterval)
            {
                result.Append((Value.Count - errosFreeIntervalStart).ToString());
            }

            return result.ToString();
        }

        // good interval length => it probability
        public Dictionary<int, double> GetGoodSequencesProbabilitiesDistribution()
        {
            return GetSequencesProbabilitiesDistribution(false);
        }

        // bad interval length => probability
        public Dictionary<int, double> GetErrorSequencesProbabilitiesDistribution()
        {
            return GetSequencesProbabilitiesDistribution(true);
        }

        private Dictionary<int, double> GetSequencesProbabilitiesDistribution(bool hasError)
        {
            int totalIntervalsCount = 0;
            int intervalLength = 0;
            bool inInterval = false;

            Dictionary<int, int> countDictionary = new Dictionary<int, int>();

            foreach (T data in Value)
            {
                if (data.HasError == hasError)
                {
                    if (!inInterval)
                    {
                        totalIntervalsCount += 1;
                        intervalLength = 1;
                    }
                    else
                    {
                        intervalLength += 1;
                    }
                    inInterval = true;
                }
                else
                {
                    if (inInterval)
                    {
                        bool isExists = countDictionary.TryGetValue(intervalLength, out int existsIntervalCount);
                        if (isExists)
                        {
                            countDictionary[intervalLength] = existsIntervalCount + 1;
                        }
                        else
                        {
                            countDictionary.Add(intervalLength, 1);
                        }
                    }
                    inInterval = false;
                }
            }

            if (inInterval)
            {
                bool isExists = countDictionary.TryGetValue(intervalLength, out int existsIntervalCount);
                if (isExists)
                {
                    countDictionary[intervalLength] = existsIntervalCount + 1;
                }
                else
                {
                    countDictionary.Add(intervalLength, 1);
                }
            }

            Dictionary<int, double> result = new Dictionary<int, double>();

            foreach (var kvp in countDictionary)
            {
                result.Add(kvp.Key, (double)kvp.Value / totalIntervalsCount);
            }

            return result.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value); ;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < Value.Count; i += 1)
            {
                result.Append(Value[i].ToString());
            }

            return result.ToString();
        }
    }
}
