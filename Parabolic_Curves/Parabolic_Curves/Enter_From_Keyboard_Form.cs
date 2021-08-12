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
    public partial class Enter_From_Keyboard_Form : Form
    {
        public Enter_From_Keyboard_Form()
        {
            InitializeComponent();
        }

        private void Enter_Coordinates_Button_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(Coordinate_count.Text) > 1)
                {
                    PC.Coordinates.Clear();
                    PC.CoordinateCount = Convert.ToInt32(Coordinate_count.Text);
                    Enter_Coordinate_Form enter_coordinate = new Enter_Coordinate_Form();
                    enter_coordinate.ShowDialog(this);
                    enter_coordinate.Dispose();
                    PC.Check_Coordinates();
                    PC.Print(KeyboardCoordinates);
                    PC.Change_Coordinates(Curve_Picture_Box);
                }
                else
                {
                    MessageBox.Show("Недостаточно параметров для построения кривой!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Неправильные входные данные!");
            }
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
                PC.Paint(Curve_Picture_Box);
                PC.Print_Time(Method_Time);
            }
            catch (Exception)
            {
                MessageBox.Show("Алгоритм не смог обработать входные данные!");
            }
        }
    }
}
