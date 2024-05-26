namespace ChannelModeling.Objects.Data
{
    public class Bit : IBinaryData
    {
        private byte Value { get; set; }

        public bool HasError => Value == 1;
        public int ErrorsCount => 1;
        public double ErrorsRate => Value;

        public Bit()
        {
            Value = 0;
        }

        public Bit(byte value)
        {
            Value = value;        
        }

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}
