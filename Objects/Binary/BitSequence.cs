using ChannelModeling.Objects.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChannelModeling.Objects
{
    public class BitSequence : Sequence<Bit>
    {
        public BitSequence(List<Bit> value) : base(value) { }

        public override String ToString()
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < Value.Count; i += 1)
            {
                result.Append(Value[i]);
            }

            return result.ToString();
        }

        public List<BitPackage> ToBitPackages(int packageLength)
        {
            List<BitPackage> result = new List<BitPackage>();

            int wholeBits = Value.Count - Value.Count % packageLength;
            for (int i = 0; i < wholeBits; i += packageLength)
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

        private BitPackage CreatePackageByIndex(int index, int packageLength)
        {
            List<Bit> buffer = new List<Bit>(packageLength);
            for (int j = 0; j < packageLength; j += 1)
            {
                buffer.Add(Value[index + j]);
            }
            return new BitPackage(buffer);
        }
    }
}
