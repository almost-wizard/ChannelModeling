using ChannelModeling.Objects.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChannelModeling.Objects
{
    public class BinarySequence<T> where T : IBinaryData
    {
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
                        result.Append((i - errosFreeIntervalStart).ToString());
                        inErrorFreeInterval = false;
                    }
                    else
                    {
                        if (i + 1 != Value.Count)
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
