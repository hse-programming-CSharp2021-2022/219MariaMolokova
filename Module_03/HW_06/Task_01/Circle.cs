using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_01
{
    public class Circle : IComparable
    {
        public Point center;
        double rad;
        public double Rad { 
            get
            { 
                return rad; 
            } 
            set 
            { 
                // Радиус 0 это точка, так что тоже будем считать ошибкой.
                if (value <= 0)
                {
                    throw new ArgumentException("Радиус меньше нуля.");
                }
                rad = value; 
            }
        }
        public Circle(double xc, double yc, double rad)
        {
            center = new Point(xc, yc);
            Rad = rad;
        }

        public override string ToString()
        {
            string format = "xc={0:g5},\tyc={1:g5},\tRad={2:g5}";
            string res = string.Format(format, center.X, center.Y, Rad);
            return res;
        }

        public int CompareTo(object obj)
        {
            Point p0 = new Point(0, 0);
            double dis1 = p0.Distance(center) * Rad;
            double dis2 = p0.Distance(((Circle)obj).center) * ((Circle)obj).Rad;
            if (dis1 > dis2) return 1;
            if (dis1 < dis2) return -1;
            return 0;
        }
    }
}
