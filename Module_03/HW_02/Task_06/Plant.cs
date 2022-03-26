using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_06
{
    public class Plant
    {
        private int growth;
        private int photosensitivity;
        private int frostresistance;

        public int Growth
        {
            get { return growth; }
            set
            {
                if (growth >= 0)
                {
                    growth = value;
                }
                else
                {
                    throw new ArgumentException("Некорректный рост.");
                }
            }
        }
        public int Photosensitivity
        {
            get { return photosensitivity; }
            set
            {
                if (photosensitivity >= 0 && photosensitivity <= 100)
                {
                    photosensitivity = value;
                }
                else
                {
                    throw new ArgumentException("Некорректная светочувствительность.");
                }
            }
        }
        public int Frostresistance
        {
            get { return frostresistance; }
            set { 
                if (frostresistance >= 0 && frostresistance <= 100)
                {
                    frostresistance = value;
                }
                else
                {
                    throw new ArgumentException("Некорректная морозоустойчивость.");
                }
            }
        }

        public Plant(int growth, int photosensitivity, int frostresistance)
        {
            Growth = growth;
            Photosensitivity = photosensitivity;
            Frostresistance = frostresistance;
        }

        public override string ToString() => "Plant." +
                                             $" Growth: {Growth}." +
                                             $" Photosensitivity: {Photosensitivity}." +
                                             $" Frostresistance: {Frostresistance}.";
    }
}
