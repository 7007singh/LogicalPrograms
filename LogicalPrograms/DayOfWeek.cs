using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class DayOfWeek
    {
        public static void GetDayOfWeek()
        {
            Console.WriteLine("Enter month mm ");
            int m = Convert.ToInt32(Console.ReadLine());

            if (m < 1 || m > 12)
            {
                Console.WriteLine("Please enter month between 1 to 12");
            }

            Console.WriteLine("Enter day ");
            int d = Convert.ToInt32(Console.ReadLine());

            if (d < 1 || d > 31)
            {
                Console.WriteLine("Please enter day between 1 to 31");
            }

            Console.WriteLine("Enter year ");
            int y = Convert.ToInt32(Console.ReadLine());

            if (y < 1000 || y > 50000)
            {
                Console.WriteLine("Enter year between -1000 to 50000");
            }

            int y0 = y - (14 - m) / 12;
            int x = y0 + y0 / 4 + y0 / 100 + y0 / 400;
            int m0 = m + 12 * ((14 - m) / 12 - 2);
            int d0 = (d + x + 31 * m0 / 12) % 7;
            Console.WriteLine(d0);

            if(d0 == 1)
            {
                Console.WriteLine("Wednesday");
            }
            else if(d0 == 2)
            {
                Console.WriteLine("Thrusday");
            }
            else if (d0 == 3) 
            {
                Console.WriteLine("Friday");
            }
            else if(d0 == 4)
            {
                Console.WriteLine("Saturday");
            }
            else if (d0 == 5)
            {
                Console.WriteLine("Sunday");
            }
            else if (d0 == 6)
            {
                Console.WriteLine("Monday");
            }
            else if  (d0 == 7)
            {
                Console.WriteLine("Tuesday");
            }
            
        }
    }
}
