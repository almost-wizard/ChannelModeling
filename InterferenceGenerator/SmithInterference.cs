using ChannelModeling.Objects.Tabler;
using System;
using System.Collections.Generic;
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

        private double CheckValue;
        private double BitErrorPropability;
        private byte CurrentBit;

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

            UpdateCheckValue();
            CulculateBitErrorPropability();
        }

        public override byte NextBit()
        {
            if (CheckValue <= BitErrorPropability)
            {
                CurrentBit = 1;
            }
            else
            {
                CurrentBit = 0;
            }
            UpdateCheckValue();
            return CurrentBit;
        }

        public string GetTransitionMatrix()
        {
            String[] header = new string[4] { "Состояние", "2",  "1", "0" };
            String[] row1 = new string[4] { "2", 0.ToString("F2"), string.Format("{0:0.##E+00}", P_21), string.Format("{0:0.##E+00}", P_20) };
            String[] row2 = new string[4] { "1", string.Format("{0:0.##E+00}", P_12), 0.ToString("F2"), 0.ToString("F2") };
            String[] row3 = new string[4] { "0", string.Format("{0:0.##E+00}", P_02), 0.ToString("F2"), 0.ToString("F2") };

            Tabler tabler = Tabler.Construct(4, 4).SetHeaderData(header).AddRowData(row1).AddRowData(row2).AddRowData(row3);
            tabler.RowTextAlign = TextAlign.CENTER;

            return String.Format("Матрица переходных состояний:\n{0}", tabler.ToString());
        }

        private void UpdateCheckValue()
        {
            CheckValue = Randomizer.NextDouble();
        }

        private void CulculateBitErrorPropability()
        {
            double P_z = P_12 * P_20 + P_02 * P_21 + P_02 * P_12;
            double P_0 = P_12 * P_20 / P_z;
            double P_1 = P_02 * P_21 / P_z;
            double P_2 = P_02 * P_12 / P_z;
            BitErrorPropability = ConditionZeroErrorPropability * P_0 + ConditionOneErrorPropability * P_1 + 
                ConditionTwoErrorPropability * P_2;
        }
    }
}
