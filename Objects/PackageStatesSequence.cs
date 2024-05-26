using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChannelModeling.Objects
{
    public class PackageStatesSequence
    {
        private List<byte> Value { get; }

        private int ErrorsCount;

        public PackageStatesSequence(List<byte> value)
        {
            Value = value;
            ErrorsCount = GetErrorsCount(value);
        }

        public override String ToString()
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < Value.Count; i += 1)
            {
                result.Append(Value[i]);
            }

            return result.ToString();
        }

        private int GetErrorsCount(List<byte> value)
        {
            return value.Where(x => x == 1).Count();
        }
    }
}
