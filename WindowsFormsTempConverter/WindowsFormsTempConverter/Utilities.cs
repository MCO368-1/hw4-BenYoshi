using System;

namespace WindowsFormsTempConverter
{
    public class Utilities
    {
        public static double ConvertTemp(Temp tempFrom, Temp tempTo, double temp)
        {
            if (tempFrom == tempTo)
            {
                return temp;
            }

            switch (tempFrom)
            {
                case Temp.Celsius:
                    return tempTo == Temp.Farenheit ? CelsiusToFahrenheit(temp) : CelsiusToKelvin(temp);
                case Temp.Farenheit:
                    return tempTo == Temp.Celsius ? FahrenheitToCelsius(temp) : FahrenheitToKelvin(temp);
                case Temp.Kelvin:
                    return tempTo == Temp.Celsius ? KelvinToCelsius(temp) : KelvinToFahrenheit(temp);
                default:
                    throw new ArgumentException("Invalid temperature type");
            }
        }

        // formulas from wikipedia: https://en.wikipedia.org/wiki/Conversion_of_units_of_temperature

        private static double CelsiusToFahrenheit(double tempInC)
        {
            return tempInC * (9.0 / 5.0) + 32;
        }

        private static double CelsiusToKelvin(double tempInC)
        {
            return tempInC + 273.15;
        }

        private static double FahrenheitToCelsius(double tempInF)
        {
            return (tempInF - 32) * (5.0 / 9.0);
        }

        private static double FahrenheitToKelvin(double tempInF)
        {
            return (tempInF + 459.67) * (5.0 / 9.0);
        }

        private static double KelvinToCelsius(double tempInK)
        {
            return tempInK - 273.15;
        }

        private static double KelvinToFahrenheit(double tempInK)
        {
            return tempInK * (9.0 / 5.0) - 459.67;
        }
    }

    public enum Temp
    {
        Celsius,
        Farenheit,
        Kelvin
    };
}