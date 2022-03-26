using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_01
{
    public class F : IFunction
    {
        private Func<double, double> calculate;
        public F(Func<double, double> calculate)
        {
            this.calculate = calculate;
        }
        public double Function(double x)
        {
            return calculate(x);
        }
    }

}
