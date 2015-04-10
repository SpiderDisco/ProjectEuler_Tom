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
            ulong sum = 0;
            //ulong nextPower = 0;
            for (ulong i = 1; i <= 1000; i++)
            {
                checked
                {
                    sum += truncate(Pow2(i, i));
                    sum = truncate(sum);
                }
                
            }
            Console.WriteLine(sum);
        }
        private static ulong truncate(ulong n)
        {
            string intString = n + "";
            if (intString.Length>10)
            {
                intString = intString.Substring(intString.Length - 10);
                return ulong.Parse(intString);
            }
            else
            {
                return n;
            }
        }
        private static ulong Pow2(ulong a, ulong b)
        {
            ulong result = 1;

            for (ulong i = 0; i < b; i++)
            {
                try
                {
                    result = checked(result *= a);
                    result = truncate(result);
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
