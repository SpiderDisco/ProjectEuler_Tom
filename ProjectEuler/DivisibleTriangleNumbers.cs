using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class DivisibleTriangleNumbers
    {
        private static List<int> primes;
        public static void Solve()
        {
            long i = 1;
            long n = 0+i;
            i++;
            //primes = FirstTen.SieveEratosthenes(1000000);
            Tuple<long, int> max = new Tuple<long, int>(0, 0);
            int temp = 0;
            while (max.Item2 < 500)
            {
                n = i + n;
                i++;
                temp = NumDivisors(n);
                if (temp > max.Item2)
                {
                    max = new Tuple<long, int>(n, temp);
                }
            }
            Console.WriteLine(max.Item1 + " : " + max.Item2);
        }
        public static int NumDivisors(long n)
        {
            //List<int> divisors = new List<int>();
            //divisors.Add(1);
            //divisors.Add(n);
            int count = 2;
            int i = 2;
            while (i < Math.Sqrt(n))
            {
                if (n % i == 0)
                {
                    count++;
                    //divisors.Add(i);
                    if (i * i != n)
                    {
                        //divisors.Add((int)(n / i));
                        count++;
                    }
                }
                i++;
            }
            return count;
        }

    }
}
