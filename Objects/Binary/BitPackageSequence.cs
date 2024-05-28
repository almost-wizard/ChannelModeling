using ChannelModeling.Objects.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChannelModeling.Objects
{
    public class BitPackageSequence : BinarySequence<BitPackage>
    {
        private static readonly String PACKAGE_SEQUENCE_DEVIDER = " | ";

        public int TotalErrorBitsCount { get; }
        public int PackageSize => Value.Count != 0 ? Value[0].Length : 0;
        public double GroupingFactor => (
            TotalErrorBitsCount != 0 && ErrorsCount != 0
                ? (Math.Log(TotalErrorBitsCount) - Math.Log(ErrorsCount)) / Math.Log(PackageSize)
                : 0
        );
        public double ErrorDensity => 1d / Math.Pow(PackageSize, 1 - GroupingFactor);

        public BitPackageSequence(List<BitPackage> value) : base(value)
        {
            TotalErrorBitsCount = GetTotalErrorBitsCount(value);
        }

        // errors count in package => packages count
        public Dictionary<int, double> GetErrorsProbabilitiesDistribution()
        {
            Dictionary<int, double> result = new Dictionary<int, double>(PackageSize + 1);

            for (int errorsCount = 0; errorsCount <= PackageSize; errorsCount += 1)
            {
                double errorPackagesCount = Value.Where(p => p.ErrorsCount == errorsCount).Count();
                result.Add(errorsCount, errorPackagesCount / Value.Count);
            }

            return result;
        }

        private int GetTotalErrorBitsCount(List<BitPackage> value)
        {
            return value.Aggregate(0, (total, next) => total += next.ErrorsCount);
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < Value.Count; i += 1)
            {
                result.Append(Value[i].ToString());

                if (i + 1 != Value.Count)
                {
                    result.Append(PACKAGE_SEQUENCE_DEVIDER);
                }
            }

            return result.ToString();
        }
    }
}
