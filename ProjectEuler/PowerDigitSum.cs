using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    //https://projecteuler.net/problem=16
    class PowerDigitSum
    {
        public static void Solve()
        {
            BigInteger n = new BigInteger(2).Pow(1000);
            BigInteger sum = new BigInteger(0);
            foreach(char c in n.ToString())
            {
                sum += new BigInteger(c.ToString(),10);
            }
            Console.WriteLine(sum);
        }
    }
}
