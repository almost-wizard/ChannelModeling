using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChannelModeling.InterferenceGenerator
{
    // provides interference generator that generates no errors
    public class IdealInterference : InterferenceGenerator
    {
        public override byte NextBit()
        {
            return 0;
        }
    }
}
