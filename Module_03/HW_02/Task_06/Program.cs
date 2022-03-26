using System;

namespace Task_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
            {
                Run(n);
            }
            else
            {
                Console.WriteLine("Вы ввели некорректное число растений.");
            }
        }

        static void Run(int n)
        {
            Plant[] plants = new Plant[n];
            for (int i = 0; i < n; i++)
            {
                int growth = GetRandomGrowth();
                int photosensitivity = GetRandomPhotosensitivity();
                int frostresistance = GetRandomFrostresistance();
                plants[i] = new Plant(growth, photosensitivity, frostresistance);
            }

            Console.WriteLine("Random:");
            Array.ForEach(plants, plant =>Console.WriteLine(plant));
            Console.WriteLine();

            Console.WriteLine("Growth (big -> small):");
            Array.Sort(plants, delegate (Plant first, Plant second) { return first.Growth > second.Growth ? -1 : 1; });
            Array.ForEach(plants, plant => Console.WriteLine(plant));
            Console.WriteLine();

            Console.WriteLine("Frostresistance (small -> big):");
            Array.Sort(plants, (Plant first, Plant second) => first.Frostresistance < second.Frostresistance ? -1 : 1);
            Array.ForEach(plants, plant => Console.WriteLine(plant));
            Console.WriteLine();

            Console.WriteLine("Photosensitivity (even -> odd):");
            Array.Sort(plants, CompareByPhotosensitivity);
            Array.ForEach(plants, plant => Console.WriteLine(plant));
            Console.WriteLine();

            Console.WriteLine("Converted:");
            Array.ConvertAll(plants, delegate (Plant plant) { return plant.Frostresistance =
                (plant.Frostresistance % 2 == 0) ? (plant.Frostresistance / 3) : (plant.Frostresistance / 2); } );
            Array.ForEach(plants, plant => Console.WriteLine(plant));
            Console.WriteLine();
        }

        private static int GetRandomGrowth()
        {
            Random random = new Random();
            return random.Next(25, 101);
        }

        private static int GetRandomPhotosensitivity()
        {
            Random random = new Random();
            return random.Next(0, 101);
        }

        private static int GetRandomFrostresistance()
        {
            Random random = new Random();
            return random.Next(0, 81);
        }

        private static int CompareByPhotosensitivity(Plant first, Plant second)
        {
            return (first.Photosensitivity % 2 < second.Photosensitivity % 2) ? -1 : 1;
        }
    }
}
