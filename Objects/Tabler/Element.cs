using System;
using System.Linq;

namespace ChannelModeling.Objects.Tabler
{
    public class Element
    {
        private static readonly string NEW_LINE = "\n";
        private static readonly string COLUMN_BLOCK = "│";
        private static readonly string ROW_BLOCK = "─";
        private static readonly string LEFT_TOP_CORNER = "┌";
        private static readonly string RIGHT_TOP_CORNER = "┐";
        private static readonly string LEFT_DOWN_CORNER = "└";
        private static readonly string RIGHT_DOWN_CORNER = "┘";
        private static readonly string LEFT_T_CORNER = "├";
        private static readonly string RIGHT_T_CORNER = "┤";
        private static readonly string TOP_T_CORNER = "┬";
        private static readonly string DOWN_T_CORNER = "┴";
        private static readonly string CROSS_CORNER = "┼";

        public abstract class Column
        {
            public abstract string Create(object obj, TextAlign textAlign, int size, int marginX);

            public static Column OPENING => new OpeningColumn();
            public static Column CLOSING => new ClosingColumn();
        }

        public class OpeningColumn : Column
        {
            public override string Create(object obj, TextAlign textAlign, int size, int marginX)
            {
                return COLUMN_BLOCK + textAlign.Apply(obj.ToString(), size, marginX);
            }
        }

        public class ClosingColumn : Column
        {
            public override string Create(object obj, TextAlign textAlign, int size, int marginX)
            {
                return COLUMN_BLOCK + textAlign.Apply(obj.ToString(), size, marginX) + COLUMN_BLOCK + NEW_LINE;
            }
        }

        public abstract class Devider
        {
            public abstract string Create(int[] columnSizes);

            public static Devider HEADER => new HeaderDevider();
            public static Devider BODY => new BodyDevider();
            public static Devider FOOTER => new FooterDevider();

            protected static string GetLine(int[] columnSizes, string leftCorner, string centerCorner, string rightCorner)
            {
                System.Text.StringBuilder mainLine = new System.Text.StringBuilder();
                for (int i = 0; i < columnSizes.Length; i++)
                {
                    if (i == 0)
                    {
                        mainLine.Append(leftCorner);
                    }
                    else
                    {
                        mainLine.Append(centerCorner);
                    }
                    mainLine.Append(String.Concat(Enumerable.Repeat(ROW_BLOCK, columnSizes[i])));
                }
                mainLine.Append(rightCorner).Append(NEW_LINE);
                return mainLine.ToString();
            }
        }

        public class HeaderDevider : Devider
        {
            public override string Create(int[] columnSizes)
            {
                return Devider.GetLine(columnSizes, LEFT_TOP_CORNER, TOP_T_CORNER, RIGHT_TOP_CORNER);
            }
        }

        public class BodyDevider : Devider
        {
            public override string Create(int[] columnSizes)
            {
                return Devider.GetLine(columnSizes, LEFT_T_CORNER, CROSS_CORNER, RIGHT_T_CORNER);
            }
        }

        public class FooterDevider : Devider
        {
            public override string Create(int[] columnSizes)
            {
                return Devider.GetLine(columnSizes, LEFT_DOWN_CORNER, DOWN_T_CORNER, RIGHT_DOWN_CORNER);
            }
        }
    }
}
