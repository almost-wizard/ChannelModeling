using System;
using System.Collections.Generic;
using System.Text;

namespace ChannelModeling.Objects.Tabler
{
    public class Tabler
    {
        private const int DEFAULT_CELL_MARGIN_X = 1;

        public object[] HeaderData { get; set; }
        public List<object[]> RowData { get; set; }
        public int[] ColumnSizes { get; set; }

        public TextAlign HeaderTextAlign { get; set; }
        public TextAlign RowTextAlign { get; set; }

        public int CellMarginX { get; }

        private Tabler(int columns, int cellMarginX = DEFAULT_CELL_MARGIN_X)
        {
            HeaderData = new object[columns];
            RowData = new List<object[]>(columns);
            ColumnSizes = new int[columns];
            CellMarginX = cellMarginX;
        }

        public static Tabler Construct(int columns, int cellMarginX)
        {
            Tabler tabler = new Tabler(columns, cellMarginX)
            {
                HeaderTextAlign = TextAlign.CENTER,
                RowTextAlign = TextAlign.LEFT,
            };

            return tabler;
        }

        public static Tabler Construct(object[] headerData)
        {
            Tabler tabler = new Tabler(headerData.Length);

            tabler.SetHeaderData(headerData);

            tabler.HeaderTextAlign = TextAlign.CENTER;
            tabler.RowTextAlign = TextAlign.LEFT;

            return tabler;
        }

        public Tabler AddRowData(object[] rowData)
        {
            RowData.Add(rowData);
            UpdateColumnSizes(rowData);

            return this;
        }

        public Tabler SetHeaderData(object[] data)
        {
            HeaderData = new object[data.Length];

            for (int i = 0; i < data.Length; i++)
            {
                HeaderData[i] = data[i];
            }

            UpdateColumnSizes(data);

            return this;
        }

        private void UpdateColumnSizes(object[] rowData)
        {
            foreach (var item in rowData)
            {
                int currentColumnLength = ColumnSizes[Array.IndexOf(rowData, item)];
                int newDataColumnLength = item.ToString().Length + CellMarginX * 2;

                if (newDataColumnLength > currentColumnLength)
                {
                    ColumnSizes[Array.IndexOf(rowData, item)] = newDataColumnLength;
                }
            }
        }

        private string CreateRow(object[] rowData, TextAlign textAlign)
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < rowData.Length; i++)
            {
                if (i + 1 == rowData.Length)
                {
                    result.Append(Element.Column.CLOSING.Create(rowData[i], textAlign, ColumnSizes[i], CellMarginX));
                }
                else
                {
                    result.Append(Element.Column.OPENING.Create(rowData[i], textAlign, ColumnSizes[i], CellMarginX));
                }
            }

            return result.ToString();
        }

        private string CreateHeader()
        {
            StringBuilder result = new StringBuilder();
            result.Append(Element.Devider.HEADER.Create(ColumnSizes));
            result.Append(CreateRow(HeaderData, HeaderTextAlign));
            result.Append(Element.Devider.BODY.Create(ColumnSizes));
            return result.ToString();
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.Append(CreateHeader());

            for (int i = 0; i < RowData.Count; i++)
            {
                result.Append(CreateRow(RowData[i], RowTextAlign));

                if (i + 1 != RowData.Count)
                {
                    result.Append(Element.Devider.BODY.Create(ColumnSizes));
                }
                
            }

            result.Append(Element.Devider.FOOTER.Create(ColumnSizes));

            return result.ToString();
        }
    }
}
