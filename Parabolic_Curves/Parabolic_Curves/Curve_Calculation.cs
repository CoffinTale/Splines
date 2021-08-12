using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;

namespace Parabolic_Curves
{
    class Curve_Calculation
    {
        private static double[,] A_matrix = { { -0.5, 1.5, -1.5, 0.5 }, { 1, -2.5, 2, -0.5 }, { -0.5, 0, 0.5, 0 }, { 0, 1, 0, 0 } }; // to Lyachek
        private static double[] T_matrix = new double[4];
        private static double[,] G_matrix = new double[4, 2];
        private static double[] TA_matrix = new double[4];
        private static double[] TAG_matrix = new double[2];
        private static List<Coordinate> curve = new List<Coordinate>();
        public static List<Coordinate> Curve
        {
            get { return curve; }
            set { curve = value; }
        }

        private static void G_Matrix_Fill(List<Coordinate> coordinates, double[,] G_matrix) // to Lyachek & Brewer-Anderson
        {
            int i = 0;
            foreach (Coordinate coordinate in coordinates)
            {
                G_matrix[i, 0] = coordinate.X;
                G_matrix[i, 1] = coordinate.Y;
                i++;
            }
        }
        private static void T_Matrix_Fill(double t, double[] T_matrix) // to Lyachek & Brewer-Anderson
        {
            T_matrix[0] = Math.Pow(t, 3);
            T_matrix[1] = Math.Pow(t, 2);
            T_matrix[2] = Math.Pow(t, 1);
            T_matrix[3] = Math.Pow(t, 0);
        }

        private static double[,] Get_A_Matrix(List<Coordinate> partofcoordinates) // to Brewer-Anderson
        {
            Thread.Sleep(1);
            double c21 = Math.Sqrt(Math.Pow(partofcoordinates[1].X - partofcoordinates[0].X, 2) + Math.Pow(partofcoordinates[1].Y - partofcoordinates[0].Y, 2));
            double c32 = Math.Sqrt(Math.Pow(partofcoordinates[2].X - partofcoordinates[1].X, 2) + Math.Pow(partofcoordinates[2].Y - partofcoordinates[1].Y, 2));
            double c43 = Math.Sqrt(Math.Pow(partofcoordinates[3].X - partofcoordinates[2].X, 2) + Math.Pow(partofcoordinates[3].Y - partofcoordinates[2].Y, 2));

            double alfa = c21 / (c32 + c21);
            double beta = c32 / (c43 + c32);

            double[,] BA_A_Matrix = new double[4, 4];

            BA_A_Matrix[0, 0] = -Math.Pow(1 - alfa, 2) / alfa;
            BA_A_Matrix[0, 1] = ((1 - alfa) + alfa * beta) / alfa;
            BA_A_Matrix[0, 2] = (-(1 - alfa) - alfa * beta) / (1 - beta);
            BA_A_Matrix[0, 3] = Math.Pow(beta, 2) / (1 - beta);

            BA_A_Matrix[1, 0] = 2 * Math.Pow(1 - alfa, 2) / alfa;
            BA_A_Matrix[1, 1] = (-2 * (1 - alfa) - alfa * beta) / alfa;
            BA_A_Matrix[1, 2] = (2 * (1 - alfa) - beta * (1 - 2 * alfa)) / (1 - beta);
            BA_A_Matrix[1, 3] = -Math.Pow(beta, 2) / (1 - beta);

            BA_A_Matrix[2, 0] = -Math.Pow(1 - alfa, 2) / alfa;
            BA_A_Matrix[2, 1] = (1 - 2 * alfa) / alfa;
            BA_A_Matrix[2, 2] = alfa;

            BA_A_Matrix[3, 1] = 1;

            return BA_A_Matrix;
        }

        private static void Matrix_Multiplication(double[] matrix1, double[,] matrix2, double[] result) // to Lyachek & Brewer-Anderson
        {
            for (int i = 0; i < matrix2.GetLength(1); i++)
            {
                double sum = 0;
                for (int j = 0; j < matrix2.GetLength(0); j++)
                {
                    sum += matrix1[j] * matrix2[j, i];
                }
                result[i] = sum;
            }
        }
        private static Coordinate Calculate_Extra_Coordinate(double[,] A_Matrix)
        {
            Matrix_Multiplication(T_matrix, A_Matrix, TA_matrix);
            Matrix_Multiplication(TA_matrix, G_matrix, TAG_matrix);
            Coordinate coordinate = new Coordinate(TAG_matrix[0], TAG_matrix[1]);
            return coordinate;
        }

        private static void Calculate_Part_Of_Curve(List<Coordinate> coordinates, double[,] A_Matrix = null)
        {
            G_Matrix_Fill(coordinates, G_matrix);
            //curve.Add(coordinates[1]);
            for (int i = 1; i < Math.Abs(Convert.ToInt32(coordinates[2].X) - Convert.ToInt32(coordinates[1].X)); i++)
            {
                Thread.Sleep(1);
                T_Matrix_Fill(Math.Abs(Convert.ToDouble(i) / (coordinates[2].X - coordinates[1].X)), T_matrix);
                if (A_Matrix == null)
                {
                    curve.Add(Calculate_Extra_Coordinate(A_matrix)); // to Lyachek
                }
                else
                {
                    curve.Add(Calculate_Extra_Coordinate(A_Matrix)); // to Brewer-Anderson
                }
            }
            //curve.Add(coordinates[2]);
        }

        private static List<Coordinate> Segment(List<Coordinate> coordinates, int part, double t0, double n)
        {
            List<double> T = new List<double>();
            List<double> S = new List<double>();
            List<double> M = new List<double>();
            List<Coordinate> X = new List<Coordinate>();

            T.Add(coordinates[1].X - coordinates[0].X);
            T.Add(coordinates[1].Y - coordinates[0].Y);
            S.Add(coordinates[2].X - coordinates[0].X);
            S.Add(coordinates[2].Y - coordinates[0].Y);
            M.Add(coordinates[2].X - coordinates[1].X);
            M.Add(coordinates[2].Y - coordinates[1].Y);

            double u = Math.Pow(S[0], 2) + Math.Pow(S[1], 2);
            double d = Math.Sqrt(u);
            double v = T[0] * S[0] + T[1] * S[1];
            double x = v / u;
            double alfa = 1 / (u * x * (1 - x));
            double t1;

            if (part == 2)
            {
                t1 = v / (t0 * d);
            }
            else
            {
                double w = M[0] * S[0] + M[1] * S[1];
                t1 = w / (t0 * d);
            }

            for (double t2 = 0; t2 < 1; t2 = t2 + n)
            {
                Thread.Sleep(1);
                double t = t0 * t2;
                double r = t * t1;
                if (part == 1)
                {
                    r = r + x * d;
                }

                double Xx = coordinates[0].X + r / d * S[0] + alfa * r * (d - r) * (T[0] - x * S[0]);

                double Xy = coordinates[0].Y + r / d * S[1] + alfa * r * (d - r) * (T[1] - x * S[1]);

                X.Add(new Coordinate(Xx, Xy));
            }
            return X;
        }
        private static void Calculate_Part_Of_Curve_Overhauser(List<Coordinate> coordinates)
        {
            List<Coordinate> P;
            List<Coordinate> Q;
            List<Coordinate> S = new List<Coordinate>();
            List<Coordinate> T = new List<Coordinate>();
            double t0 = Math.Sqrt(Math.Pow(coordinates[2].X - coordinates[1].X, 2) + Math.Pow(coordinates[2].Y - coordinates[1].Y, 2));
            for (int i = 0; i < 3; i++)
            {
                S.Add(coordinates[i]);
                T.Add(coordinates[i + 1]);
            }

            P = Segment(S, 1, t0, 1 / Math.Abs((coordinates[2].X) - (coordinates[1].X)));
            Q = Segment(T, 2, t0, 1 / Math.Abs((coordinates[2].X) - (coordinates[1].X)));

            int k = 0;
            for (double t = 0; t < 1; t = t + (1 / Math.Abs(((coordinates[2].X) - (coordinates[1].X)))))
            {
                Thread.Sleep(1);
                double Cx = (1 - t) * P[k].X + t * Q[k].X;

                double Cy = (1 - t) * P[k].Y + t * Q[k].Y;

                Coordinate C = new Coordinate(Cx, Cy);
                curve.Add(C);
                k++;
            }
        }

        /*private static void Calculate_Part_Of_Curve_Overhauser(List<Coordinate> coordinates)
        {
            double d = Math.Sqrt(Math.Pow(coordinates[2].X - coordinates[0].X, 2) + Math.Pow(coordinates[2].Y - coordinates[0].Y, 2));

            double e = Math.Sqrt(Math.Pow(coordinates[3].X - coordinates[1].X, 2) + Math.Pow(coordinates[3].Y - coordinates[1].Y, 2));

            double xP = ((coordinates[1].X - coordinates[0].X) * (coordinates[2].X - coordinates[0].X) + (coordinates[1].Y - coordinates[0].Y) * (coordinates[2].Y - coordinates[0].Y)) / Math.Pow(d, 2);

            double xQ = ((coordinates[2].X - coordinates[1].X) * (coordinates[3].X - coordinates[1].X) + (coordinates[2].Y - coordinates[1].Y) * (coordinates[3].Y - coordinates[1].Y)) / Math.Pow(e, 2);

            double alfa = 1 / (Math.Pow(d, 2) * xP * (1 - xP));

            double beta = 1 / (Math.Pow(e, 2) * xQ * (1 - xQ));

            double t0 = Math.Sqrt(Math.Pow(coordinates[2].X - coordinates[1].X, 2) + Math.Pow(coordinates[2].Y - coordinates[1].Y, 2)); // distance between P2 and P3

            double cosTetaP = ((coordinates[2].X - coordinates[1].X) * (coordinates[2].X - coordinates[0].X) + (coordinates[2].Y - coordinates[1].Y) * (coordinates[2].Y - coordinates[0].Y)) /
                (t0 * d);

            double cosTetaQ = ((coordinates[2].X - coordinates[1].X) * (coordinates[3].X - coordinates[1].X) + (coordinates[2].Y - coordinates[1].Y) * (coordinates[3].Y - coordinates[1].Y)) /
                (t0 * e);

            curve.Add(coordinates[1]);

            for (int i = 1; i < Math.Abs(Convert.ToInt32(coordinates[2].X) - Convert.ToInt32(coordinates[1].X)); i++)
            {
                double t = t0 * Math.Abs(Convert.ToDouble(i) / (coordinates[2].X - coordinates[1].X));

                ///////////////////////////////////////////////////////////////////////////////////////////////////////////////

                double r = xP * d + t * cosTetaP;

                double Px = coordinates[0].X + r / d * (coordinates[2].X - coordinates[0].X) +
                    alfa * r * (d - r) * ((coordinates[1].X - coordinates[0].X) - xP * (coordinates[2].X - coordinates[0].X));

                double Py = coordinates[0].Y + r / d * (coordinates[2].Y - coordinates[0].Y) +
                    alfa * r * (d - r) * ((coordinates[1].Y - coordinates[0].Y) - xP * (coordinates[2].Y - coordinates[0].Y));

                ///////////////////////////////////////////////////////////////////////////////////////////////////////////////

                double s = t * cosTetaQ;

                double Qx = coordinates[1].X + s / e * (coordinates[3].X - coordinates[1].X) +
                    beta * s * (e - s) * ((coordinates[2].X - coordinates[1].X) - xQ * (coordinates[3].X - coordinates[1].X));

                double Qy = coordinates[1].Y + s / e * (coordinates[3].Y - coordinates[1].Y) +
                    beta * s * (e - s) * ((coordinates[2].Y - coordinates[1].Y) - xQ * (coordinates[3].Y - coordinates[1].Y));

                ///////////////////////////////////////////////////////////////////////////////////////////////////////////////

                double Cx = (1 - t / t0) * Px + (t / t0) * Qx;

                double Cy = (1 - t / t0) * Py + (t / t0) * Qy;

                Coordinate C = new Coordinate(Cx, Cy);
                curve.Add(C);
            }
            curve.Add(coordinates[2]);
        }*/

        public static void Calculate_Curve(int flag)
        {
            var startTime = System.Diagnostics.Stopwatch.StartNew();
            startTime.Restart();
            // 0 - Overhauser
            // 1 - Brewer-Anderson
            // 2 - Lyachek

            for (int i = 0; i < PC.Coordinates.Count; i++)
            {
                Thread.Sleep(1);
                List<Coordinate> partofcoordinates = new List<Coordinate>();
                if (i == 0)
                {
                    if (flag != 2)
                    {
                        Coordinate newcoordinate = new Coordinate(PC.Coordinates[i].X - 0.0001, PC.Coordinates[i].Y - 0.0001);
                        partofcoordinates.Add(newcoordinate);
                    }
                    else
                        partofcoordinates.Add(PC.Coordinates[i]);
                    partofcoordinates.Add(PC.Coordinates[i]);
                    partofcoordinates.Add(PC.Coordinates[i + 1]);
                    if (PC.Coordinates.Count == 2) // for two
                    {
                        Coordinate newcoordinate = new Coordinate(PC.Coordinates[i + 1].X + 0.0001, PC.Coordinates[i + 1].Y + 0.0001);
                        switch (flag)
                        {
                            case 0:
                                partofcoordinates.Add(newcoordinate);
                                Calculate_Part_Of_Curve_Overhauser(partofcoordinates);
                                break;
                            case 1:
                                partofcoordinates.Add(newcoordinate);
                                Calculate_Part_Of_Curve(partofcoordinates, Get_A_Matrix(partofcoordinates));
                                break;
                            case 2:
                                partofcoordinates.Add(PC.Coordinates[i + 1]);
                                Calculate_Part_Of_Curve(partofcoordinates);
                                break;
                        }
                        break;
                    }
                    else
                        partofcoordinates.Add(PC.Coordinates[i + 2]);
                }
                else if (i == PC.Coordinates.Count - 2)
                {
                    partofcoordinates.Add(PC.Coordinates[i - 1]);
                    partofcoordinates.Add(PC.Coordinates[i]);
                    partofcoordinates.Add(PC.Coordinates[i + 1]);
                    if (flag != 2)
                    {
                        Coordinate newcoordinate = new Coordinate(PC.Coordinates[i + 1].X + 0.0001, PC.Coordinates[i + 1].Y + 0.0001);
                        partofcoordinates.Add(newcoordinate);
                    }
                    else
                        partofcoordinates.Add(PC.Coordinates[i + 1]);
                    switch (flag)
                    {
                        case 0:
                            Calculate_Part_Of_Curve_Overhauser(partofcoordinates);
                            break;
                        case 1:
                            Calculate_Part_Of_Curve(partofcoordinates, Get_A_Matrix(partofcoordinates));
                            break;
                        case 2:
                            Calculate_Part_Of_Curve(partofcoordinates);
                            break;
                    }
                    break;
                }
                else
                {
                    partofcoordinates.Add(PC.Coordinates[i - 1]);
                    partofcoordinates.Add(PC.Coordinates[i]);
                    partofcoordinates.Add(PC.Coordinates[i + 1]);
                    if (PC.Coordinates.Count == 3) // for 3
                    {
                        Coordinate newcoordinate = new Coordinate(PC.Coordinates[i + 1].X + 0.0001, PC.Coordinates[i + 1].Y + 0.0001);
                        switch (flag)
                        {
                            case 0:
                                partofcoordinates.Add(newcoordinate);
                                Calculate_Part_Of_Curve_Overhauser(partofcoordinates);
                                break;
                            case 1:
                                partofcoordinates.Add(newcoordinate);
                                Calculate_Part_Of_Curve(partofcoordinates, Get_A_Matrix(partofcoordinates));
                                break;
                            case 2:
                                partofcoordinates.Add(PC.Coordinates[i + 1]);
                                Calculate_Part_Of_Curve(partofcoordinates);
                                break;
                        }
                        break;
                    }
                    else
                    {
                        partofcoordinates.Add(PC.Coordinates[i + 2]);
                    }
                }
                if (flag == 1)
                {
                    Calculate_Part_Of_Curve(partofcoordinates, Get_A_Matrix(partofcoordinates));
                }
                else if (flag == 2)
                    Calculate_Part_Of_Curve(partofcoordinates);
                else
                    Calculate_Part_Of_Curve_Overhauser(partofcoordinates);
            }
            startTime.Stop();
            var resultTime = startTime.Elapsed;
            PC.Time = Convert.ToDouble(resultTime.TotalMilliseconds);
        }
    }
}
