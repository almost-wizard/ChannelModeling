using System;
using System.Text;

namespace ChannelModeling.InterferenceGenerator
{
    public class MarkovInterference : InterferenceGenerator
    {
        private readonly App.Randomizer Randomizer = App.Randomizer.GetInstance();

        private readonly double ErrorProbability;
        private readonly double GroupingCoefficient;
        private readonly int BlockLength;

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
            double roundedP11 = Math.Round(P_11, 2);
            double calculatedP10 = 1 - roundedP11;
            double roundedP01 = Math.Round(P_01, 2);
            double calculatedP00 = 1 - roundedP01;

            StringBuilder format = new StringBuilder();
            format.Append($"┌───────────┬────────────┬────────────┐\r\n");
            format.Append($"│ Состояние │      1     │      0     │\r\n");
            format.Append($"├───────────┼────────────┼────────────┤\r\n");
            format.Append($"│     1     │    {roundedP11}    │    {calculatedP10}    │\r\n");
            format.Append($"├───────────┼────────────┼────────────┤\r\n");
            format.Append($"│     0     │    {roundedP01}    │    {calculatedP00}    │\r\n");
            format.Append($"└───────────┴────────────┴────────────┘");
            return format.ToString();
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
