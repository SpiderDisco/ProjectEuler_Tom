using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class DistinctPowers
    {
        public static void Solve()
        {
            List<ulong> distinctPowers = new List<ulong>();
            ulong c;
            for (uint a = 2; a <= 100; a++)
            {
                for (uint b = 2; b <= 100; b++)
                {
                    c = Pow2(a, b);
                    if (!distinctPowers.Contains(c))
                    {
                        distinctPowers.Add(c);
                    }
                }
            }
            Console.WriteLine(distinctPowers.Count);
            Console.WriteLine(distinctPowers.Max());
            Console.WriteLine(distinctPowers.Min());
            Console.ReadKey();
        }
        private static ulong Pow2(uint a, uint b)
        {
            ulong result=1;

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
