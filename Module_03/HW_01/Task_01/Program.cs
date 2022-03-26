using System;

namespace Task_01
{
    class Program
    {
        delegate int Cast(double x);
        static void Main(string[] args)
        {
            Cast even = delegate (double x)
            {
                int floor = (int) Math.Floor(x);
                if (floor % 2 == 0)
                {
                    return floor;
                }
                return floor + 1;
            };
            Cast exponent = delegate (double x)
            {
                return (int) Math.Log10(x) + 1;
            };
            Console.WriteLine("test delegates:");
            Console.WriteLine(even(3.1));
            Console.WriteLine(exponent(3.1));

            Cast newEven = (x) =>
            {
                int floor = (int)Math.Floor(x);
                if (floor % 2 == 0)
                {
                    return floor;
                }
                return floor + 1;
            };
            Cast newExponent = (x) => (int)Math.Log10(x) + 1;

            Cast newCast = newEven + newExponent;

            Console.WriteLine("test lambda +:");
            Console.WriteLine(newCast?.Invoke(3.1));

            newCast -= (x) => (int)(Math.Log10(x)) + 1;
            Console.WriteLine("test lambda -:");
            Console.WriteLine(newCast?.Invoke(3.1));
        }
    }
}
