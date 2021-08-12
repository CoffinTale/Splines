using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Parabolic_Curves
{
    class PC
    {
        private static int coordinatecount;
        public static int CoordinateCount
        {
            get { return coordinatecount; }
            set { coordinatecount = value; }
        }

        private static List<Coordinate> coordinates = new List<Coordinate>();
        public static List<Coordinate> Coordinates
        {
            get { return coordinates; }
            set { coordinates = value; }
        }

        private static double time;
        public static double Time
        {
            get { return time; }
            set { time = value; }
        }

        public static void Parse_Coordinates(string string_to_parse)
        {
            List<string> strings = new List<string>();
            string_to_parse += "\n\r";
            string temp = "";
            foreach (char symbol in string_to_parse)
            {
                if (symbol != '\n')
                {
                    temp += symbol;
                }
                else
                {
                    strings.Add(temp);
                    temp = "";
                }
            }
            string x = "";
            string y = "";
            foreach (string str in strings)
            {
                int i = 0;
                while (i < str.Length)
                {
                    if (str[i] != ' ' && str[i] != '\r')
                    {
                        x += str[i];
                        i++;
                    }
                    else
                    {
                        i++;
                        break;
                    }
                }
                while (i < str.Length)
                {
                    if (str[i] != ' ' && str[i] != '\r')
                    {
                        y += str[i];
                        i++;
                    }
                    else
                    {
                        break;
                    }
                }
                Coordinate coordinate = new Coordinate(Convert.ToDouble(x), Convert.ToDouble(y));
                coordinates.Add(coordinate);
                x = "";
                y = "";
            }
        }

        private static double Critical_Value(List<Coordinate> targetcurve, string value, char axis)
        {
            double newvalue;
            if (axis == 'x')
                newvalue = targetcurve[0].X;
            else
                newvalue = targetcurve[0].Y;
            foreach (Coordinate coordinate in targetcurve)
            {
                if (value == "max")
                {
                    if (axis == 'x')
                    {
                        if (coordinate.X > newvalue)
                            newvalue = coordinate.X;
                        else
                        if (coordinate.X > newvalue)
                            newvalue = coordinate.X;
                    }
                    else
                    {
                        if (coordinate.Y > newvalue)
                            newvalue = coordinate.Y;
                        else
                        if (coordinate.Y > newvalue)
                            newvalue = coordinate.Y;
                    }
                }
                else
                {
                    if (axis == 'x')
                    {
                        if (coordinate.X < newvalue)
                            newvalue = coordinate.X;
                        else
                        if (coordinate.X < newvalue)
                            newvalue = coordinate.X;
                    }
                    else
                    {
                        if (coordinate.Y < newvalue)
                            newvalue = coordinate.Y;
                        else
                        if (coordinate.Y < newvalue)
                            newvalue = coordinate.Y;
                    }
                }
            }
            return newvalue;
        }

        private static void Multiplier(double multiplier)
        {
            foreach (Coordinate coordinate in coordinates)
            {
                coordinate.X = coordinate.X * multiplier;
                coordinate.Y = coordinate.Y * multiplier;
            }
        }

        public static void Change_Coordinates(PictureBox picturebox)
        {
            double x_distance = Critical_Value(coordinates, "max", 'x') - Critical_Value(coordinates, "min", 'x');
            double y_distance = Critical_Value(coordinates, "max", 'y') - Critical_Value(coordinates, "min", 'y');
            if (x_distance <= picturebox.Width - 20 && y_distance <= picturebox.Height - 20)
            {
                if (picturebox.Width / x_distance <= picturebox.Height / y_distance)
                {
                    double multiplier = (picturebox.Width - 20 - x_distance) / x_distance;
                    Multiplier(1+multiplier);
                }
                else
                {
                    double multiplier = (picturebox.Height - 20 - y_distance) / y_distance;
                    Multiplier(1+multiplier);
                }
            }
            else
            {
                if ( x_distance / picturebox.Width >= y_distance / picturebox.Height)
                {
                    double multiplier = (x_distance - picturebox.Width + 20) / x_distance;
                    Multiplier(1 - multiplier);
                }
                else
                {
                    double multiplier = (y_distance - picturebox.Height + 20) / y_distance;
                    Multiplier(1 - multiplier);
                }
            }
        }

        public static void Check_Coordinates()
        {
            for (int i = 0; i < coordinates.Count - 1; i++)
            {

                if (coordinates[i].X != coordinates[i + 1].X && coordinates[i].Y != coordinates[i + 1].Y)
                {
                    continue;
                }
                else
                {
                    coordinates.Remove(coordinates[i]);
                }
            }
        }

        public static void Print(TextBox textbox)
        {
            for (int i = 0; i < coordinates.Count; i++)
            {
                textbox.Text += " ( " + coordinates[i].X + " , " + coordinates[i].Y + " )\r\n";
            }
        }

        public static void Paint(PictureBox picturebox)
        {
            Graphics lines = picturebox.CreateGraphics();
            lines.Clear(Color.White);
            Pen axis = new Pen(Color.LightGray);
            Pen line = new Pen(Color.Black);

            double max = Critical_Value(Curve_Calculation.Curve, "max", 'x');
            double min = Critical_Value(Curve_Calculation.Curve, "min", 'x');

            int x_displacement = (picturebox.Width - Convert.ToInt32(max - min)) / 2 - Convert.ToInt32(min);

            max = Critical_Value(Curve_Calculation.Curve, "max", 'y');
            min = Critical_Value(Curve_Calculation.Curve, "min", 'y');

            int y_displacement = (picturebox.Height - Convert.ToInt32(max - min)) / 2 + Convert.ToInt32(max);

            lines.DrawLine(axis, x_displacement, 0, x_displacement, picturebox.Height);
            lines.DrawLine(axis, 0, y_displacement, picturebox.Width, y_displacement);

            for (int i = 0; i < Curve_Calculation.Curve.Count - 1; i++)
            {
                lines.DrawLine(line,
                    Convert.ToInt32(Curve_Calculation.Curve[i].X) + x_displacement,
                    Convert.ToInt32(-Curve_Calculation.Curve[i].Y) + y_displacement,
                    Convert.ToInt32(Curve_Calculation.Curve[i + 1].X) + x_displacement,
                    Convert.ToInt32(-Curve_Calculation.Curve[i + 1].Y) + y_displacement);
            }
        }

        public static void Print_Time(TextBox textBox)
        {
            textBox.Text = Convert.ToString(Time);
        }

        /*private static void Sort_Coordinates()
        {
            for (int i = 0; i < coordinates.Count; i++)
            {
                for (int j = coordinates.Count - 1; j > i; j--)
                {
                    if (coordinates[j - 1].X > coordinates[j].X)
                    {
                        Coordinate temp = coordinates[j - 1];
                        coordinates[j - 1] = coordinates[j];
                        coordinates[j] = temp;
                    }

                }
            }

        }*/
    }
}
