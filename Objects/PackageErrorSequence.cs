using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChannelModeling.Objects
{
    public class PackageErrorSequence
    {
        private static readonly String PACKAGE_SEQUENCE_DEVIDER = " | ";

        List<PackageError> Value { get; }
        private int ErrorsCount { get; }

        public double ErrorsRate { get { return (double)ErrorsCount / Value.Count; } }

        public PackageErrorSequence(List<PackageError> value)
        {
            Value = value;
            ErrorsCount = GetErrorsCount(value);
        }

        private int GetErrorsCount(List<PackageError> value)
        {
            // TODO: if there are errors in the package, count as 1 error or the number of errors in the package
            return value.Where(x => x.GetErrorsCount() != 0).Count();
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < Value.Count; i += 1)
            {
                result.Append(Value[i].ToString());

                if (i + 1 !=  Value.Count)
                {
                    result.Append(PACKAGE_SEQUENCE_DEVIDER);
                }
            }

            return result.ToString();
        }
    }
}
