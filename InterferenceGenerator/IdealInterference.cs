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
