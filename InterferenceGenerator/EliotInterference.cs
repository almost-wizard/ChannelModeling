using ChannelModeling.Objects.Tabler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChannelModeling.InterferenceGenerator
{
    internal class EliotInterference : InterferenceGenerator
    {
        private readonly App.Randomizer Randomizer = App.Randomizer.GetInstance();

        private double ErrorPropability;

        private double AverageErrorFreeSequenceLength;
        private double AverageErrorSequenceLength;

        private byte CurrentBit;
        private double CheckValue;

        public EliotInterference(double averageErrorFreeSequenceLength, double averageErrorSequenceLength)
        {
            AverageErrorFreeSequenceLength = averageErrorFreeSequenceLength;
            AverageErrorSequenceLength = averageErrorSequenceLength;
            CulculateErrorPropability();
        }

        public override byte NextBit()
        {
            if (Randomizer.NextDouble() <= ErrorPropability)
            {
                return (byte)1;
            }
            else
            {
                return (byte)0;
            }
        }

        private void CulculateErrorPropability()
        {
            ErrorPropability = Math.Pow(AverageErrorFreeSequenceLength / AverageErrorSequenceLength + 1, -1);
        }
    }
}
