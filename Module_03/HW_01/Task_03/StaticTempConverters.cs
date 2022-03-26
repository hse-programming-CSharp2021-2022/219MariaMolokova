using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_03
{
    public static class StaticTempConverters
    {
        public static double CelsiusToKelvin(double t) => t + 273.15;
        public static double KelvinToCelsius(double t) => t - 273.15;
        public static double CelsiusToRankin(double t) => 9 * (t + 273.15) / 5;
        public static double RankinToCelsius(double t) => 5 * (t - 491.67) / 9;
        public static double CelsiusToReomur(double t) => 4 * t / 5;
        public static double ReomurToCelsius(double t) => 5 * t / 4;
    }
}
