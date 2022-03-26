using System;

namespace Task_01
{
    internal class Program
    {
        static void Main()
        {
            F f1 = new F(x => x * x + 4);
            F f2 = new F(x => Math.Sin(x));
            G g = new G(f1, f2);
            for (double x = 0; x < Math.PI; x += Math.PI / 16)
            {
                Console.WriteLine($"(x = {x:f4}; g(x) = {g.GF(x):f4})");
            }
        }
    }
}
