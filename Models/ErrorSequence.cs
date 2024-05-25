using ChannelModeling.Objects;

namespace ChannelModeling.Models
{
    public class ErrorSequence
    {
        private InterferenceGenerator.InterferenceGenerator InterferenceGenerator { get; }

        public BitErrorSequence BitErrorSequence { get; set; }
        public PackageErrorSequence PackageErrorSequence { get; set; }

        public ErrorSequence(InterferenceGenerator.InterferenceGenerator interferenceGenerator, int sequenceLength, int packageLength)
        {
            InterferenceGenerator = interferenceGenerator;

            BitErrorSequence = new BitErrorSequence(InterferenceGenerator.GenerateInterferences(sequenceLength));
            PackageErrorSequence = new PackageErrorSequence(BitErrorSequence.ToPackageErrors(packageLength));
        }
    }
}
