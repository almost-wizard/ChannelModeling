using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChannelModeling.Objects
{
    public class BitErrorSequence
    {
        private List<byte> Value { get; }
        private int ErrorsCount { get; }

        public double ErrorsRate { get { return (double)ErrorsCount / Value.Count; } }

        public BitErrorSequence(List<byte> value)
        {
            Value = value;
            ErrorsCount = GetErrorsCount(value);
        }

        public override String ToString()
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < Value.Count; i += 1)
            {
                result.Append(Value[i]);
            }

            return result.ToString();
        }

        public List<PackageError> ToPackageErrors(int packageLength)
        {
            List<PackageError> result = new List<PackageError>();

            for (int i = 0; i < Value.Count; i += packageLength)
            {
                result.Add(CreatePackageByIndex(i, packageLength));
            }

            int remindesBits = Value.Count % packageLength;

            if (remindesBits > 0)
            {
                int filled = Value.Count / packageLength * packageLength;
                result.Add(CreatePackageByIndex(filled, remindesBits));
            }

            return result;
        }

        public String ToIntervalString()
        {
            StringBuilder result = new StringBuilder();

            bool inErrorFreeInterval = false;
            int errosFreeIntervalStart = -1;

            for (int i = 0; i < Value.Count; i++)
            {
                if (Value[i] == 0)
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
                        result.Append(0);
                    }
                }
            }

            if (inErrorFreeInterval)
            {
                result.Append((Value.Count - errosFreeIntervalStart).ToString());
            }

            return result.ToString();
        }

        private PackageError CreatePackageByIndex(int index, int packageLength)
        {
            List<byte> buffer = new List<byte>(packageLength);
            for (int j = 0; j < packageLength; j += 1)
            {
                buffer.Add(Value[index + j]);
            }
            return new PackageError(buffer);
        }

        private int GetErrorsCount(List<byte> value)
        {
            return value.Where(x => x == 1).Count();
        }
    }
}
