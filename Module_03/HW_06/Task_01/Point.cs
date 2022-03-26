using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_01
{
    public class Point
    {
        public double X { get; set; }
        public double Y { get; set; }
        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }
        public double Distance(Point another)
        {
            return Math.Sqrt(Math.Pow(X - another.X, 2) + Math.Pow(Y - another.Y, 2));
        }
    }
}
