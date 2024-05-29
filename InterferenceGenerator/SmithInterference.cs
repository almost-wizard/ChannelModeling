using ChannelModeling.Objects.Tabler;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChannelModeling.InterferenceGenerator
{
    public class SmithInterference : InterferenceGenerator
    {
        private readonly App.Randomizer Randomizer = App.Randomizer.GetInstance();

        private double ConditionZeroErrorPropability;
        private double ConditionOneErrorPropability;
        private double ConditionTwoErrorPropability;
        private double P_21;
        private double P_20;
        private double P_12;
        private double P_02;

        private byte CurrentBit;
        private int Stage;

        public SmithInterference(double conditionZeroPropability, double conditionOnePropability, 
            double conditionTwoPropability, double p_21, double p_20, double p_12, double p_02)
        {
            ConditionZeroErrorPropability = conditionZeroPropability;
            ConditionOneErrorPropability = conditionOnePropability;
            ConditionTwoErrorPropability = conditionTwoPropability;
            P_21 = p_21;
            P_20 = p_20;
            P_12 = p_12;
            P_02 = p_02;
        }

        public override byte NextBit()
        {
            double CheckValue = Randomizer.NextDouble();
            if (Stage == 2)
            {
                if (CheckValue > P_21)
                {
                    if (Randomizer.NextDouble() <= ConditionTwoErrorPropability)
                    {
                        CurrentBit = 1;
                    }
                    else
                    {
                        CurrentBit = 0;
                    }
                }
                else if (CheckValue < P_20)
                {
                    Stage = 1;
                    if (Randomizer.NextDouble() <= ConditionOneErrorPropability)
                    {
                        CurrentBit = 1;
                    }
                    else
                    {
                        CurrentBit = 0;
                    }
                }
                else
                {
                    Stage = 0;
                    if (Randomizer.NextDouble() <= ConditionZeroErrorPropability)
                    {
                        CurrentBit = 1;
                    }
                    else
                    {
                        CurrentBit = 0;
                    }
                }
            }
            else if (Stage == 1)
            {
                if (CheckValue < P_12)
                {
                    if (Randomizer.NextDouble() <= ConditionOneErrorPropability)
                    {
                        CurrentBit = 1;
                    }
                    else
                    {
                        CurrentBit = 0;
                    }
                }
                else
                {
                    Stage = 2;
                    if (Randomizer.NextDouble() <= ConditionTwoErrorPropability)
                    {
                        CurrentBit = 1;
                    }
                    else
                    {
                        CurrentBit = 0;
                    }
                }
            }
            else
            {
                if (CheckValue < P_02)
                {
                    if (Randomizer.NextDouble() <= ConditionZeroErrorPropability)
                    {
                        CurrentBit = 1;
                    }
                    else
                    {
                        CurrentBit = 0;
                    }
                }
                else
                {
                    Stage = 2;
                    if (Randomizer.NextDouble() <= ConditionTwoErrorPropability)
                    {
                        CurrentBit = 1;
                    }
                    else
                    {
                        CurrentBit = 0;
                    }
                }
            }
            return CurrentBit;
        }

        public string GetTransitionMatrix()
        {
            String[] header = new string[4] { "Состояние", "2",  "1", "0" };
            String[] row1 = new string[4] { "2", "-", string.Format("{0:0.##E+00}", P_21), string.Format("{0:0.##E+00}", P_20) };
            String[] row2 = new string[4] { "1", string.Format("{0:0.##E+00}", P_12), "-", "-" };
            String[] row3 = new string[4] { "0", string.Format("{0:0.##E+00}", P_02), "-", "-" };

            Tabler tabler = Tabler.Construct(4, 4).SetHeaderData(header).AddRowData(row1).AddRowData(row2).AddRowData(row3);
            tabler.RowTextAlign = TextAlign.CENTER;

            return String.Format("Матрица переходных состояний:\n{0}", tabler.ToString());
        }

        private void InitStage()
        {
            if (Randomizer.NextDouble() <= ((double)1 / 3))
            {
                Stage = 2;
            }
            else if (Randomizer.NextDouble() <= ((double)2 / 3))
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
