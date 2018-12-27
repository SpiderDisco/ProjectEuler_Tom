using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    //https://projecteuler.net/problem=25
    class _1000DigitFib
    {
        public static void Solve()
        {
            BigInteger f1, f2;
            f1 = 0;
            f2 = 1;
            while (f1.ToString().Length < 1000)
            {
                f2 += f1;
                f1 = f2 - f1;
            }
            Console.WriteLine(f1);
        }
    }
}
