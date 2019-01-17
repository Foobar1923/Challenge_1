using System;

namespace Challenge_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                create a calculator application that has use in your life. 
                It might be an interest calculator, or it might be something that you can use in the classroom. 
                For example, if you were in physics class, you might want to make a F = M * A calc.

                Temperature Converter - F <-> C <-> K

                F -> C
                    (32°F − 32) × 5/9 = 0°C
                F -> K
                    (32°F − 32) × 5/9 + 273.15 = 273.15K
                C -> F
                    (0°C × 9/5) + 32 = 32°F
                C -> K
                    0°C + 273.15 = 273.15K
                K -> F
                    (0K − 273.15) × 9/5 + 32 = -459.7°F
                K -> C
                    0K − 273.15 = -273.1°C

             */

            string tempInput;
            double tempConvert, tempCel, tempKel;
            Console.WriteLine("What temperature do you want to start with in Faranheit: ");
            tempInput = Console.ReadLine();
            tempConvert = Convert.ToDouble(tempInput);            
            tempCel = convertToCelcius(tempConvert);
            tempCel = Convert.ToInt32(tempCel);
            tempKel = convertToKelvin(tempConvert);
            tempKel = Convert.ToInt32(tempKel);
            Console.WriteLine("Temperature: {0}C {1}K", tempCel, tempKel);

            double convertToCelcius(double temp)
            {
                double x;
                x = (temp - 32) * (0.55555555555);
                return x;
            }

            double convertToKelvin(double temp)
            {
                double x;
                x = ((temp - 32) * 0.55555555555) + 273.15;
                return x;
            }
        }
    }
}