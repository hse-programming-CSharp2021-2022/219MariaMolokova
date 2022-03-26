using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_01
{
    public class Fibonacci
    {
        public IEnumerable<int> GetNums(int n)
        {
            var f1 = 1;
            var f2 = 1;
            for (var i = 0; i < n; i++)
            {
                (f1, f2) = (f2, f1 + f2);
                yield return f1;
            }
        }
    }
}
