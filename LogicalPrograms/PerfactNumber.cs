using System;

namespace LogicalPrograms
{
    internal class PerfactNumber
    {
        public static void FindPerfectNumber()
        {
            Console.WriteLine("Please enter a number to check whether it is perfect or not");
            int number = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for(int i = 1; i <= number/2; i++) 
            {
                if(number%i == 0)
                {
                    Console.Write("Divisor: {0},",i);
                    sum += i;
                }
            }
            if (sum == number)
            {
                Console.WriteLine("\n{0} is a Perfect Number", number);
            }
            else
            {
                Console.WriteLine("{0} not a Perfect number", number);
            }
        }
    }
}
