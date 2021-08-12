using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parabolic_Curves
{
    public partial class Enter_From_File_Form : Form
    {
        public Enter_From_File_Form()
        {
            InitializeComponent();
        }

        private void Enter_From_File_Load(object sender, EventArgs e)
        {
            if (PC.Coordinates.Count <= 1)
            {
                MessageBox.Show("Недостаточно параметров для построения кривой!");
                this.Dispose();
            }
            PC.Print(FileCoordinates);
            PC.Change_Coordinates(Curve_Picture_Box);
        }

        private void Calculate_Curve_Button_Click(object sender, EventArgs e)
        {
            try
            {
                switch (Method.SelectedIndex)
                {
                    case 0:
                        Curve_Calculation.Curve.Clear();
                        Curve_Calculation.Calculate_Curve(0);
                        break;
                    case 1:
                        Curve_Calculation.Curve.Clear();
                        Curve_Calculation.Calculate_Curve(1);
                        break;
                    case 2:
                        Curve_Calculation.Curve.Clear();
                        Curve_Calculation.Calculate_Curve(2);
                        break;
                    default:
                        Curve_Calculation.Curve.Clear();
                        Curve_Calculation.Calculate_Curve(2);
                        break;
                }
                PC.Print_Time(Method_Time);
                PC.Paint(Curve_Picture_Box);
            }
            catch (Exception)
            {
                MessageBox.Show("Алгоритм не смог обработать входные данные!");
            }
        }
    }
}
