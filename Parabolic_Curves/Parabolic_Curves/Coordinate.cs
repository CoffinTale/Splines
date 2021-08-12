using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parabolic_Curves
{
    class Coordinate
    {
        private double x;
        public double X
        {
            get { return x; }
            set { x = value; }
        }
        private double y;
        public double Y
        {
            get { return y; }
            set { y = value; }
        }
        public Coordinate(double _x, double _y)
        {
            this.x = _x;
            this.y = _y;
        }
    }
}
