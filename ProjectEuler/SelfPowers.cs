using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class SelfPowers
    {
        public static void Solve()
        {
            int sum = 0;
            for (int i = 1; i <= 1000; i++)
            {
                sum += (int)Math.Pow(i, i);
                if (sum > 1000000000)
                {
                    string sumStr = sum + "";
                    sumStr = sumStr.Substring(sumStr.Length - 10);
                    sum = int.Parse(sumStr);
                }
            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }
        private static int Pow2(int a, int b)
        {
            int result = 1;

            for (int i = 0; i < b; i++)
            {
                try
                {
                    result = checked(result *= a);
                }
                catch (System.OverflowException e)
                {
                    Console.WriteLine("CHECKED and CAUGHT:  " + e.ToString());
                }

            }
            return result;
        }
    }
}
