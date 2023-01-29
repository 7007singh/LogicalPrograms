using System;

namespace LogicalPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Program number for execution");
            Console.WriteLine("1:FibonacciSeries\n2:FindPerfactNumber\n3:CheckPrimeOrNot");
            int option = Convert.ToInt32(Console.ReadLine());
            switch(option)
            {
                case 1:
                    Console.Clear();
                    FibonacciSeries.FindFibonacciSeries();
                    Console.ReadLine();
                    break;   
                case 2:
                    Console.Clear();
                    PerfactNumber.FindPerfectNumber();
                    Console.ReadLine();
                    break;
                case 3:
                    Console.Clear();
                    PrimeNumber.CheckPrimeOrNot();
                    Console.ReadLine();
                    break;
            }
        }
    }
}
