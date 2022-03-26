using System;

namespace Task_03
{
    delegate double DelegateConvertTemperature(double x);
    class Program
    {
        static void Main()
        {
            DelegateConvertTemperature fahrenheitToCelsius = new TemperatureConverterImp().FahrenheitToCelsius;
            DelegateConvertTemperature celsiusToFahrenheit = new TemperatureConverterImp().CelsiusToFahrenheit;

            Console.WriteLine("Test:");
            Console.WriteLine(fahrenheitToCelsius(14)); // - 10
            Console.WriteLine(celsiusToFahrenheit(-10)); // 14
            Console.WriteLine();

            DelegateConvertTemperature celsiusToKelvin = new DelegateConvertTemperature(StaticTempConverters.CelsiusToKelvin);
            DelegateConvertTemperature celsiusToRankin = new DelegateConvertTemperature(StaticTempConverters.CelsiusToRankin);
            DelegateConvertTemperature celsiusToReomur = new DelegateConvertTemperature(StaticTempConverters.CelsiusToReomur);

            var converters = new DelegateConvertTemperature[] { celsiusToFahrenheit, celsiusToKelvin, celsiusToRankin, celsiusToReomur };

            Console.WriteLine("Input degrees Celsius:");
            double temperature = double.Parse(Console.ReadLine());
            foreach (var converter in converters)
            {
                Console.WriteLine(converter(temperature) + " degrees " + converter.Method.Name.Substring(9));
            }
        }
    }
}
