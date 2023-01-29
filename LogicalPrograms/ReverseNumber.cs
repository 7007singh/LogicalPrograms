using System;

namespace LogicalPrograms
{
    internal class ReverseNumber
    {
        public static void GetReverseNumber()
        {
            Console.WriteLine("Please enter a number to find reverse");
            int number = Convert.ToInt32(Console.ReadLine());
            int reverse = 0, remainder;
            while(number != 0)
            {
                remainder = number % 10;
                reverse = (reverse * 10) + remainder;
                number = number / 10;
            }
            Console.WriteLine("Reverse: " + reverse);
        }
    }
}
