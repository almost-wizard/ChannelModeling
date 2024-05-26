using ChannelModeling.Objects.Data;
using System.Collections.Generic;

namespace ChannelModeling.InterferenceGenerator
{
    public abstract class InterferenceGenerator
    {
        public List<Bit> GenerateInterferences(int length = 8)
        {
            List<Bit> result = new List<Bit>(length);

            for (int i = 0; i < length; i += 1)
            {
                result.Add(new Bit(NextBit()));
            }

            return result;
        }

        public abstract byte NextBit(); // 0/1
    }
}
