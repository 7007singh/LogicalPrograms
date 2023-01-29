using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class PrimeNumber
    {
        public static void CheckPrimeOrNot()
        {
            Console.WriteLine("Enter a number to check");
            int number = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            for(int i = 1; i <= number; i++)
            {
                if(number%i == 0)
                {
                    count++;
                }
            }
            if(count==2)
            {
                Console.WriteLine("{0} is Prime Number", number);
            }
            else
            {
                Console.WriteLine("{0} is Non-Prime Number", number);
            }
        }
    }
}
