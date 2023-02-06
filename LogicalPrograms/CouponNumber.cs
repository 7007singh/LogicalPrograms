using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    class CouponNumber
    {
        public static void FindDistinctCouponNumber()
        {
            char[] arr = new char[99];
            char[] chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789".ToCharArray();

            Random random = new Random();

            for (int i = 0; i <= 5; i++)
            {
                int randomCode = random.Next(chars.Length);
                arr[i] = (chars[randomCode]);
                Console.Write(arr[i]);

                if (arr.Contains(arr[i]))
                {
                    continue;
                }
                else
                {
                    arr[i] = chars[randomCode];
                }
            }
        }
    }
}
