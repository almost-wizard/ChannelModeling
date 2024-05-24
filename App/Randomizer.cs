using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChannelModeling.App
{
    public class Randomizer
    {
        private static Randomizer Instance;
        private Random Random;

        private Randomizer() { }

        public static Randomizer GetInstance()
        {
            if (Instance == null)
            {
                Instance = new Randomizer();
            }
            return Instance;
        }

        public void SetSeed(int? seed = null)
        {
            if (seed.HasValue)
            {
                Random = new Random((int)seed);
            }
            else
            {
                Random = new Random();
            }
        }

        public int Next()
        {
            return Random.Next();
        }

        public int Next(int max)
        {
            return Random.Next(max);
        }

        public int Next(int min, int max)
        {
            return Random.Next(min, max);
        }

        public double NextDouble()
        {
            return Random.NextDouble();
        }
    }
}
