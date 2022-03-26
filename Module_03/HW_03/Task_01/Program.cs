using System;
using DotLib;

namespace Task_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (int.TryParse(Console.ReadLine(), out var x))
            {
                if (int.TryParse(Console.ReadLine(), out var y))
                {
                    Run(x, y);
                    return;
                }
            }
            Console.WriteLine("Координаты не инты:(");
        }

        static void Run(int x, int y)
        {
            Dot D = new Dot(x, y);
            D.OnCoordChanged += PrintInfo;
            D.DotFlow();
        }

        static void PrintInfo(Dot A)
        {
            Console.WriteLine($"Dot: {A.X}, {A.Y}");
        }
    }
}
