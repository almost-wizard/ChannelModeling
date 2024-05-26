using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChannelModeling.InterferenceGenerator
{
    public class MarkovInterference : InterferenceGenerator
    {
        private readonly App.Randomizer Randomizer = App.Randomizer.GetInstance();
        private double ErrorProbability;
        private double GroupingCoefficient;
        private int BlockLength;

        private double P_11;
        private double P_01;
        private double P_10;
        private double P_00;

        private double CheckValue;
        private byte CurrentBit;

        public MarkovInterference(double errorProbability, double groupingCoefficient, int blockLength)
        {
            ErrorProbability = errorProbability;
            GroupingCoefficient = groupingCoefficient;
            BlockLength = blockLength;
            InitBit();
            CulculateTransientProbabilities();
            UpdateCheckValue();
        }

        public override byte NextBit()
        {
            UpdateCheckValue();
            if (CurrentBit == 1)
            {
                if (CheckValue <= P_11)
                {
                    CurrentBit = 1;
                    return CurrentBit;
                }
                CurrentBit = 0;
                return CurrentBit;
            }
            if (CheckValue <= P_01)
            {
                CurrentBit = 1;
                return CurrentBit;
            }
            CurrentBit = 0;
            return CurrentBit;
        }

        public string GetTransitionMatrix()
        {
            return $"{P_11} {P_10} \n\n{P_01} {P_00}";
        }

        private void CulculateTransientProbabilities()
        {
            P_11 = 2 - Math.Pow(2, 1 - GroupingCoefficient);
            P_00 = (1 - Math.Pow(2 * BlockLength, 1 - GroupingCoefficient) * ErrorProbability) / (1 - Math.Pow(BlockLength, 1 - GroupingCoefficient) * ErrorProbability);
            P_01 = 1 - P_00;
            P_10 = 1 - P_11;
        }

        private void InitBit()
        {
            CurrentBit = 0;
            double t = Randomizer.NextDouble();
            if (t < 0.5)
            {
                CurrentBit = 1;
            }
        }

        private void UpdateCheckValue()
        {
            CheckValue = Randomizer.NextDouble();
        }
    }
}
