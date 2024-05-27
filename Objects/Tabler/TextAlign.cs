using System;
using System.Linq;

namespace ChannelModeling.Objects.Tabler
{
    public abstract class TextAlign
    {
        public abstract string Apply(string text, int length, int marginX);

        public static TextAlign LEFT = new LeftTextAlign();
        public static TextAlign CENTER = new CenterTextAlign();
        public static TextAlign RIGHT = new RightTextAlign();
        private const string MARGIN_PLACEHOLDER = " ";

        private class LeftTextAlign : TextAlign
        {
            public override string Apply(string text, int length, int marginX)
            {
                int marginRight = length - text.Length - marginX;
                return RepeatString(MARGIN_PLACEHOLDER, marginX) + text + RepeatString(MARGIN_PLACEHOLDER, marginRight);
            }
        }

        private class CenterTextAlign : TextAlign
        {
            public override string Apply(string text, int length, int marginX)
            {
                int spacesLength = length - text.Length;
                int marginRight = spacesLength / 2;
                int marginLeft = marginRight + spacesLength % 2;
                return RepeatString(MARGIN_PLACEHOLDER, marginLeft) + text + RepeatString(MARGIN_PLACEHOLDER, marginRight);
            }
        }

        private class RightTextAlign : TextAlign
        {
            public override string Apply(string text, int length, int marginX)
            {
                int marginLeft = length - text.Length - marginX;
                return RepeatString(MARGIN_PLACEHOLDER, marginLeft) + text + RepeatString(MARGIN_PLACEHOLDER, marginX);
            }
        }

        private static string RepeatString(string str, int count)
        {
            return String.Concat(Enumerable.Repeat(str, count));
        }
    }
}
