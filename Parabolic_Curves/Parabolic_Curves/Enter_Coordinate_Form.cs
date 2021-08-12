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
    public partial class Enter_Coordinate_Form : Form
    {
        public Enter_Coordinate_Form()
        {
            InitializeComponent();
        }

        private void Next_button_Click(object sender, EventArgs e)
        {
            try
            {
                Coordinate coordinate = new Coordinate(Convert.ToDouble(x_coordinate.Text), Convert.ToDouble(y_coordinate.Text));
                PC.Coordinates.Add(coordinate);
                int num = Convert.ToInt32(Coordinate_number.Text);
                num++;
                if (num <= PC.CoordinateCount)
                {
                    Coordinate_number.Text = Convert.ToString(num);
                    x_coordinate.Clear();
                    x_coordinate.Select();
                    y_coordinate.Clear();
                }
                else
                {
                    this.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Неправильные входные данные!");
            }
        }

        private void Enter_Coordinate_Load(object sender, EventArgs e)
        {
            x_coordinate.Select();
        }

        private void x_coordinate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                if (x_coordinate.SelectionStart == x_coordinate.TextLength)
                {
                    y_coordinate.Select();
                }
            }
        }

        private void y_coordinate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                if (y_coordinate.SelectionStart == 0)
                {
                    x_coordinate.Select();
                }
            }
        }
    }
}
