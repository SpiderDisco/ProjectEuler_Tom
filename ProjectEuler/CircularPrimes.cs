using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class CircularPrimes
    {
        static List<int> primes;
        static List<int> circularPrimes;
        public static void Solve()
        {
            primes = FirstTen.SieveEratosthenes(1000000);
            circularPrimes = new List<int>() { 2, 3, 5, 7, 11, 13, 17, 31, 37, 71, 73, 79, 97 };
            foreach(int prime in primes)
            {
                if (!circularPrimes.Contains(prime) && IsCircular(prime))
                {
                    circularPrimes.Add(prime);
                }
            }
            Console.WriteLine(circularPrimes.Count);
        }
        static bool IsCircular(int p)
        {
            string n = p + "";

            return false;
        }
    }
}
