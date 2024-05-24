using System.Collections.Generic;

namespace ChannelModeling.InterferenceGenerator
{
    public abstract class InterferenceGenerator
    {
        public List<byte> GenerateInterferences(int length = 8)
        {
            List<byte> result = new List<byte>(length);

            for (int i = 0; i < length; i += 1)
            {
                result.Add(NextBit());
            }

            return result;
        }

        public abstract byte NextBit(); // 0/1
    }
}
