using ChannelModeling.Objects.Data;
using ChannelModeling.Objects.Tabler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChannelModeling.InterferenceGenerator
{
    public class GilbertInterference : InterferenceGenerator
    {
        private readonly App.Randomizer Randomizer = App.Randomizer.GetInstance();

        private double PackageErrorPropability;
        private double P_10;
        private double P_01;

        private byte Stage;

        public GilbertInterference(double packageErrorPropability, double p_10, double p_01)
        {
            PackageErrorPropability = packageErrorPropability;
            P_10 = p_10;
            P_01 = p_01;
            InitStage();
        }

        public override byte NextBit()
        {
            double CheckValue = Randomizer.NextDouble();
            if (Stage == 1)
            {
                if (CheckValue > P_10)
                {
                    if (Randomizer.NextDouble() <= PackageErrorPropability)
                    {
                        return (byte) 1;
                    }
                    else
                    {
                        return (byte) 0;
                    }
                }
                else
                {
                    Stage = 0;
                    return (byte)0;
                }
            }
            else
            {
                if (CheckValue > P_01)
                {
                    return (byte)0;
                }
                else
                {
                    Stage = 1;
                    if (Randomizer.NextDouble() <= PackageErrorPropability)
                    {
                        return (byte)1;
                    }
                    else
                    {
                        return (byte)0;
                    }
                }
            }
        }

        public string GetTransitionMatrix()
        {
            double roundedP10 = Math.Round(P_10, 2);
            double calculatedP11 = 1 - roundedP10;
            double roundedP01 = Math.Round(P_01, 2);
            double calculatedP00 = 1 - roundedP01;

            String[] header = new string[3] { "Состояние", "1", "0" };
            String[] row1 = new string[3] { "1", calculatedP11.ToString("F2"), roundedP10.ToString("F2") };
            String[] row2 = new string[3] { "0", roundedP01.ToString("F2"), calculatedP00.ToString("F2") };

            Tabler tabler = Tabler.Construct(3, 3).SetHeaderData(header).AddRowData(row1).AddRowData(row2);
            tabler.RowTextAlign = TextAlign.CENTER;

            return String.Format("Матрица переходных состояний:\n{0}", tabler.ToString());
        }

        private void InitStage()
        {
            if (Randomizer.NextDouble() <= 0.5)
            {
                Stage = 1;
            }
            else
            {
                Stage = 0;
            }
        }
    }
}
