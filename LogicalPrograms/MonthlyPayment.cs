using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class MonthlyPayment
    {
        public static void GetMonthlyPayment()
        {
            Console.WriteLine("Please enter the principle amount");
            double P = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the year");
            double Y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the interest rate");
            double R = Convert.ToInt32(Console.ReadLine());

            double n = 12 * Y;
            double r = R / (12 * 100);
            double payment = (P * r) / (1 - Math.Pow((1 + r), -n));
            Console.WriteLine("Monthly Payment: {0}",payment);
        }
    }
}
