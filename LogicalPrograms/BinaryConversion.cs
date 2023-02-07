using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class BinaryConversion
    {
        public static void toBinary()
        {
            Console.WriteLine("Enter any decimal number");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[10];
            int i = 0;
            int count = 0;
            while (n > 0) 
            {
                
                int remainder = n % 2;
                n = n / 2;
                arr[i] = remainder;                 
                i++;
                count++;
            }
            Console.Write("\n");
            for (int j=count-1;j>=0;j--) 
            {                
                Console.Write(arr[j]);
            }

            while( n != 1)
            {
                n = n / 2;
            }
            if (n == 1)
            {
                Console.WriteLine("{0} is belongs to binary decomposition",n);
            }
            else
            {
                Console.WriteLine("{0} is not belons to binary decomposition", n);
            }
        }
    }
}
