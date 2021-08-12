using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Parabolic_Curves
{
    public partial class Parabolic_Curves_Main_Form : Form
    {
        public Parabolic_Curves_Main_Form()
        {
            InitializeComponent();
        }

        private void Enter_from_keyboard_Click(object sender, EventArgs e)
        {
            Enter_From_Keyboard_Form enterkeyboard = new Enter_From_Keyboard_Form();
            this.Hide();
            enterkeyboard.ShowDialog(this);
            enterkeyboard.Dispose();
            this.Show();

        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Enter_from_file_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog open_file_dialog = new OpenFileDialog();
                string file_string;
                PC.Coordinates.Clear();
                if (open_file_dialog.ShowDialog() == DialogResult.OK)
                {
                    var file_stream = open_file_dialog.OpenFile();
                    using (StreamReader reader = new StreamReader(file_stream))
                    {
                        file_string = reader.ReadToEnd();
                    }
                    PC.Parse_Coordinates(file_string);
                    PC.Check_Coordinates();
                    Enter_From_File_Form enter_file = new Enter_From_File_Form();
                    this.Hide();
                    enter_file.ShowDialog(this);
                    enter_file.Dispose();
                    this.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
