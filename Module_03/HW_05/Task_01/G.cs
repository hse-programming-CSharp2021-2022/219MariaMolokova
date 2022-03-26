using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_01
{
    public class G
    {
        private F f1;
        private F f2;
        public G(F f1, F f2)
        {
            this.f1 = f1;
            this.f2 = f2;
        }
        public double GF(double x0)
        {
            return f1.Function(f2.Function(x0));
        }
    }
}
