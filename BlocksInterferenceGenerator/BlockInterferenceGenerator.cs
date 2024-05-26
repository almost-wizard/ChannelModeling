using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChannelModeling.BlocksInterferenceGenerator
{
    public abstract class BlockInterferenceGenerator
    {
        public List<byte> GenerateBlockInterferences(int length = 8)
        {
            List<byte> result = new List<byte>(length);

            for (int i = 0; i < length; i += 1)
            {
                result.Add(NextBlock());
            }

            return result;
        }

        public abstract byte NextBlock(); // 0/1
    }
}
