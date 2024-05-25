using ChannelModeling.ExtensionMethods;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ChannelModeling.Objects
{
    public class PackageError
    {
        public int Value { get; set; }   // stores sequence in decimal and represents in in binary
        public int Length { get; set; }

        public PackageError(int length)
        {
            Length = length;
        }

        public PackageError(int value, int length)
        {
            Value = value;
            Length = length;
        }

        public PackageError(List<byte> bits)
        {
            Value = Convert.ToInt32(String.Join("", bits), 2);
            Length = bits.Count;
        }

        public int GetErrorsCount()
        {
            return this.ToBits().Where(x => x == '1').Count();
        }

        public override string ToString()
        {
            return this.ToBits();
        }
    }
}
