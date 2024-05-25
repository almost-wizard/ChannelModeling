using System;

namespace ChannelModeling.ExtensionMethods
{
    public static class Methods
    {
        public static string Repeat(this string s, int count)
        {
            string result = "";
            for (; count > 0; count--)
            {
                result += s;
            }
            return result;
        }

        public static string Repeat(this char s, int count)
        {
            string result = "";
            for (; count > 0; count--)
            {
                result += s;
            }
            return result;
        }

        public static string ToBits(this int value, int length)
        {
            string binary = Convert.ToString(value, 2);
            binary = "0".Repeat(length - binary.Length) + binary;
            return binary;
        }

        public static string ToBits(this int value)
        {
            return ToBits(value, value.ToString().Length);
        }

        public static string ToBits(this Objects.PackageError obj)
        {
            return ToBits(obj.Value, obj.Length);
        }
    }
}
