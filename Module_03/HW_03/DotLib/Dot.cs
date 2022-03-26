using System;

namespace DotLib
{
    public delegate void CoordChanged(Dot dot);
    public class Dot
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Dot(int x, int y)
        {
            X = x;
            Y = y;
        }

        public event CoordChanged OnCoordChanged;
        public void DotFlow()
        {
            for (var i = 0; i < 10; i++)
            {
                X = GetRandomCoordinate();
                Y = GetRandomCoordinate();
                if (X < 0 && Y < 0)
                {
                    OnCoordChanged?.Invoke(this);
                }
            }
        }

        private int GetRandomCoordinate()
        {
            Random random = new Random();
            return random.Next(-10, 11);
        }
    }
}
