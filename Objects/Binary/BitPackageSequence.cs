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

        private int GetTotalErrorBitsCount(List<BitPackage> value)
        {
            return value.Aggregate(0, (total, next) => total += next.ErrorsCount);
        }

        public BitSequence GetPackagesStages()
        {
            List<Bit> bits = new List<Bit>();
            Bit bit_1 = new Bit((byte) 1);
            Bit bit_0 = new Bit((byte) 0);
            for (int i = 0; i < Value.Count; i += 1)
            {
                if (Value[i].HasError)
                {
                    bits.Add(bit_1);
                    continue;
                }
                bits.Add(bit_0);
            }
            return new BitSequence(bits);
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
