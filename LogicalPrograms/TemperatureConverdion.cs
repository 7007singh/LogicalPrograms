using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace CsharpPractice
{
    internal class TemperatureConversion
    {
        public static void ConvertTemperature()
        {
            Console.WriteLine("Please enter temperature to convert into fahrenheit");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter temperature to convert into celsius");
            int f = Convert.ToInt32(Console.ReadLine());

            int fahrenheit = (c * 9 / 5) + +32;
            int celsius = (f - 32) * 5 / 9;
            Console.WriteLine("{0} degree celsius in fahrenheit {1}F", c, fahrenheit);
            Console.WriteLine("{0} fahrenheit in degree celsius {1}C", f, celsius);
        }
    }
}
