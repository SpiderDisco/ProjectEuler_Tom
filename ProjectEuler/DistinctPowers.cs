using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class DistinctPowers
    {
        //https://projecteuler.net/problem=29
        public static void Solve()
        {
            List<BigInteger> distinctPowers = new List<BigInteger>();
            BigInteger c;
            for (int a = 2; a <= 100; a++)
            {
                for (int b = 2; b <= 100; b++)
                {
                    c = new BigInteger(a).Pow(b);
                    if (!distinctPowers.Contains(c))
                    {
                        distinctPowers.Add(c);
                    }
                }
            }
            //distinctPowers.Sort();
            Console.WriteLine();
            Console.WriteLine(distinctPowers.Count);
        }
    }
}
