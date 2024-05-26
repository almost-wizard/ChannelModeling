using System;

namespace ChannelModeling.InterferenceGenerator
{
    public class BinomialInterference : InterferenceGenerator
    {
        private readonly App.Randomizer Randomizer = App.Randomizer.GetInstance();

        private double ErrorProbability;
        private int TotalErrorsCount;
        private double CheckSum;
        private byte CurrentBit;

        public BinomialInterference(double errorProbability)
        {
            if (errorProbability < 0 || errorProbability > 1)
            {
                throw new ArgumentException("Error probability must be between 0 and 1.");
            }

            ErrorProbability = errorProbability;
            TotalErrorsCount = 0;
            InitBit();
            UpdateChecksum();
        }

        public override byte NextBit()
        {
            if (CheckSum < 0)
            {
                ChangeBit();
                UpdateChecksum();
                TotalErrorsCount = 0;
            }

            CheckSum -= CalculateInterval();
            TotalErrorsCount += 1;

            return CurrentBit;
        }

        private void InitBit()
        {
            CurrentBit = 0;
            double t = Randomizer.NextDouble();
            if (t < 0.5)
            {
                ChangeBit();
            }
        }

        private void ChangeBit()
        {
            CurrentBit = (byte)(1 - CurrentBit);
            ErrorProbability = 1 - ErrorProbability; //last formula from page 34
        }

        private void UpdateChecksum()
        {
            CheckSum = Randomizer.NextDouble();
        }

        private double CalculateInterval()
        {
            return ErrorProbability * Math.Pow(1 - ErrorProbability, TotalErrorsCount);
        }
    }
}
