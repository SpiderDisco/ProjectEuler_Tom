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
            primes = Program.SieveEratosthenes(1000000);
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
            string primeString = p + "";
            string rotation = rotate(primeString);
            for(int i=0; i<primeString.Length; i++)
            {
                if(!primes.Contains(int.Parse(rotation)))
                {
                    return false;
                }
                rotation = rotate(rotation);
            }
            return true;
        }
        static string rotate(string s)
        {
            return s.Remove(0, 1) + s[0];
        }
    }
}
