using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChannelModeling.Models
{
    public class ErrorSequence
    {
        private static readonly String PACKAGE_SEQUENCE_DEVIDER = " | ";

        private InterferenceGenerator.InterferenceGenerator InterferenceGenerator { get; }

        private int SequenceLength { get; }
        private int PackageLength { get; }

        public String BitsSequence { get; set; }
        public String IntervalsSequence { get; set; }

        public ErrorSequence(InterferenceGenerator.InterferenceGenerator interferenceGenerator, int sequenceLength, int packageLength)
        {
            InterferenceGenerator = interferenceGenerator;
            SequenceLength = sequenceLength;
            PackageLength = packageLength;
        }

        public void Simulate()
        {
            List<byte> bits = InterferenceGenerator.GenerateInterferences(SequenceLength);

            BitsSequence = CalculateBitsSequence(bits);
            IntervalsSequence = CalculateIntervalsSequence(bits);
        }

        private String CalculateBitsSequence(List<byte> bits)
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < bits.Count; i += 1)
            {
                result.Append(bits[i]);

                if ((i + 1) % PackageLength == 0 && i + 1 != bits.Count)
                {
                    result.Append(PACKAGE_SEQUENCE_DEVIDER);
                }
            }

            return result.ToString();
        }

        private String CalculateIntervalsSequence(List<byte> bits)
        {
            StringBuilder result = new StringBuilder();

            bool inErrorFreeInterval = false;
            int errosFreeIntervalStart = -1;

            for (int i = 0; i < bits.Count; i++)
            {
                if (bits[i] == 0)
                {
                    if (!inErrorFreeInterval)
                    {
                        inErrorFreeInterval = true;
                        errosFreeIntervalStart = i;
                    }
                }
                else
                {
                    if (inErrorFreeInterval)
                    {
                        result.Append((i - errosFreeIntervalStart).ToString());
                        inErrorFreeInterval = false;
                    }
                    else
                    {
                        result.Append(0);
                    }
                }
            }

            if (inErrorFreeInterval)
            {
                result.Append((bits.Count - errosFreeIntervalStart).ToString());
            }

            return result.ToString();
        }
    }
}
