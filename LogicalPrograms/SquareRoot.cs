using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class SquareRoot
    {
        public static void ComputeSquareRootUsingNewtonMethod() 
        {
            Console.WriteLine("Please enter a number to convert in square root");
            double c = Convert.ToInt32(Console.ReadLine());
            double t = c;            
            double epsilon = 1e-15;

            while(Math.Abs(t - c/t)>epsilon*t)
            {
                t = (c / t + t) / 2;
            }
            Console.WriteLine(t);
        }
    }
}
