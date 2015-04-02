using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class PrimeGeneratingIntegers
    {
        public static void Solve()
        {
            List<int> primes = SieveEratosthenes(100000000);
            bool fail;
            int sum = 0;
            for (int i = 3; i < 100000000; i++)
            {
                fail = false;
                foreach (int n in GetDivisors(i))
                {
                    if (!primes.Contains((int)(n + i / (double)n)))
                    {
                        fail = true;
                        continue;
                    }
                }
                if (!fail)
                {
                    Console.WriteLine(i);
                    sum += i;
                }
            }
            Console.WriteLine("============");
            Console.WriteLine(sum);
            Console.ReadKey();
        }
        private static List<int> GetDivisors(int n)
        {
            List<int> Divisors = new List<int>();
            int x = 1;
            while (x < n)
            {
                if (n % x == 0)
                {
                    Divisors.Add(x);
                }
                x++;
            }
            return Divisors;
        }
        public static List<int> SieveEratosthenes(int max)
        {
            bool[] N = new bool[max];
            for (int i = 0; i < N.Length; i++)
                N[i] = true;
            N[0] = N[1] = false;

            for (int i = 2; i < N.Length; i++)
            {
                if (N[i])
                {
                    for (int j = (2 * i); j < N.Length; j += i)
                    {
                        N[j] = false;
                    }
                }
            }
            List<int> result = new List<int>();
            for (int i = 0; i < N.Length; i++)
            {
                if (N[i])
                {
                    result.Add(i);
                }
            }
            return result;
        }
    }
}
