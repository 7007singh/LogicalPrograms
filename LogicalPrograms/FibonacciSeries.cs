using System;

namespace LogicalPrograms
{
    internal class FibonacciSeries
    {
        public static void FindFibonacciSeries()
        {
            Console.WriteLine("Input number of terms to print fibonacci series");
            int term = Convert.ToInt32(Console.ReadLine());
            int firstNumber = 0; int secondNumber = 1;
            Console.Write("{0} + {1} + ",firstNumber, secondNumber);
            for(int i = 0; i <= term; i++)
            {
                int thirdNumber = firstNumber + secondNumber;
                Console.Write(" {0} + ",thirdNumber);
                firstNumber = secondNumber;
                secondNumber = thirdNumber;
            } 
        }
    }
}
