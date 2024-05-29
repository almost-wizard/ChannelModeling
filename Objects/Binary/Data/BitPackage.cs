using ChannelModeling.ExtensionMethods;
using System.Collections.Generic;
using System.Linq;
using System;

namespace ChannelModeling.Objects.Data
{
    public class BitPackage : IBinaryData
    {
        public long Value { get; set; }   // stores sequence in decimal and represents it in binary

        public int Length { get; }  // for represent data in binary
        public bool HasError => ErrorsCount > 0;
        public int ErrorsCount { get; }
        public double ErrorsRate => (double)ErrorsCount / this.ToBits().Length;

        public BitPackage(int length)
        {
            Value = 0;
            Length = length;
            ErrorsCount = 0;
        }

        public BitPackage(int value, int length)
        {
            Value = value;
            Length = length;
            ErrorsCount = GetErrorsCount();
        }

        public BitPackage(List<Bit> bits)
        {
            Value = Convert.ToInt64(String.Join("", bits), 2);
            Length = bits.Count;
            ErrorsCount = GetErrorsCount();
        }

        private int GetErrorsCount()
        {
            return this.ToBits().Where(x => x == '1').Count();
        }

        public override string ToString()
        {
            return this.ToBits();
        }
    }
}
