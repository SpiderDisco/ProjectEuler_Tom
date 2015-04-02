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
            primes = FirstTen.SieveEratosthenes(1000);
            circularPrimes = new List<int>();
        }
        public bool IsCircular(int p)
        {
            string n = p + "";
            return false;
        }
    }
}
