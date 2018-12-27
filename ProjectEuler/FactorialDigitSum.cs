using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    //https://projecteuler.net/problem=20
    class FactorialDigitSum
    {
        public static void Solve()
        {
            BigInteger n = Factorial(100);
            BigInteger sum = new BigInteger(0);
            foreach(char c in n.ToString())
            {
                sum += new BigInteger(c.ToString(), 10);
            }
            Console.WriteLine(sum);
        }
        static BigInteger Factorial(int n)
        {
            BigInteger result = new BigInteger(1);
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}
