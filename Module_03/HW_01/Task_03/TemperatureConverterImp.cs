using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_03
{
    public class TemperatureConverterImp
    {
        public double FahrenheitToCelsius(double t) => 5 * (t - 32) / 9;
        public double CelsiusToFahrenheit(double t) => 9 * t / 5 + 32;
    }
}
