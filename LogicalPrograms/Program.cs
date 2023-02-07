using CsharpPractice;
using System;

namespace LogicalPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Program number for execution");
            Console.WriteLine("1:FibonacciSeries\n2:FindPerfactNumber\n3:CheckPrimeOrNot\n4:ReverseNumber\n5:CouponNumber\n6:StopWatch\n7:VendingMachine" +
                "\n8:DayOfWeek\n9:TemperaturreConversion\n10:Monthly Payment\n11:SquareRootUsingNewtonMethod\n12:BinaryConversion");
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
                case 4:
                    Console.Clear();
                    ReverseNumber.GetReverseNumber();
                    Console.ReadLine();
                    break;
                case 5:
                    Console.Clear();
                    CouponNumber.FindDistinctCouponNumber();
                    Console.ReadLine();
                    break;
                case 6:
                    Console.Clear();
                    StopWatch.GetElapsedTime();
                    Console.ReadLine();
                    break;
                case 7:
                    Console.Clear();
                    VendingMachine.GetMinimumNotes();
                    Console.ReadLine();
                    break;
                case 8:
                    Console.Clear();
                    DayOfWeek.GetDayOfWeek();
                    Console.ReadLine();
                    break;
                case 9:
                    Console.Clear();
                    TemperatureConversion.ConvertTemperature();
                    Console.ReadLine();
                    break;
                case 10:
                    Console.Clear();
                    MonthlyPayment.GetMonthlyPayment();
                    Console.ReadLine();
                    break;
                case 11:
                    Console.Clear();
                    SquareRoot.ComputeSquareRootUsingNewtonMethod();
                    Console.ReadLine();
                    break;
                case 12:
                    Console.Clear();
                    BinaryConversion.toBinary();
                    Console.ReadLine();
                    break;
            }
        }
    }
}
