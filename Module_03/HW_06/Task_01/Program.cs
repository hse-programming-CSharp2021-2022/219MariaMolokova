using System;
using System.Collections.Generic;

namespace Task_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Circle> list = new List<Circle>();
            Point p0 = new Point(0, 0); // начало координат
            Circle ct; // ссылка на очередной объект, вводимый с клавиатуры  
            do
            {
                double r = 0, x = 0, y = 0;
                bool isOk = false;
                do
                {
                    Console.WriteLine("Введите r:");
                    if (double.TryParse(Console.ReadLine(), out r) && r > 0)
                    {
                        Console.WriteLine("Введите x:");
                        if (double.TryParse(Console.ReadLine(), out x))
                        {
                            Console.WriteLine("Введите yc:");
                            if (double.TryParse(Console.ReadLine(), out y))
                            {
                                isOk = true;
                            }
                        }
                    }
                } while (!isOk);

                ct = new Circle(x, y, r);
                list.Add(ct);
                // Сортируем список (в обратном порядке):
                /*list.Sort((c1, c2) =>
                {
                    double dis1 = p0.Distance(c1.center) * c1.Rad;
                    double dis2 = p0.Distance(c2.center) * c2.Rad;
                    if (dis1 > dis2) return -1;
                    if (dis1 < dis2) return +1;
                    return 0;
                });*/
                list.Sort();
                //.. Выводим элементы списка:
                foreach (Circle cir in list)
                    Console.WriteLine(cir.ToString());
                Console.WriteLine("Для завершения работы нажмите Escape ");
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
