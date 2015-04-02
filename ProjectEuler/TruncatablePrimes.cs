using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    static class TruncatablePrimes
    {
        private static string[] primes;// =
            //Array.ConvertAll(Program.SieveEratosthenes(100000).ToArray(), item => item.ToString());
            //Array.ConvertAll(Program.DoPrimeCount(100000).ToArray(), item => item.ToString());
            //File.ReadAllLines(@"..\..\Files\10kprimes.txt")[0].Split(',');
        private static List<int> results = new List<int>();
        public static void Solve()
        {
            Console.WriteLine("{0} primes being checked", primes.Length);
            //string[] ignore = new string[] { "2", "3", "5", "7" };
            int currentNumber = 13;
            int maxPrime = 10000;
            primes = Array.ConvertAll(Program.SieveEratosthenes(maxPrime).ToArray(), item => item.ToString());
            while(results.Count<11)
            {
                if (CheckTruncates(currentNumber.ToString()))
                {
                    results.Add(currentNumber);
                    Console.WriteLine("{0}: {1}",results.Count,currentNumber);
                }
                currentNumber++;
                if (currentNumber > maxPrime)
                {
                    maxPrime *= 2;

                }
            }
            Console.WriteLine(results.Sum());
            Console.ReadKey();

        }
        private static bool CheckTruncates(string n)
        {
            return LeftToRight(n.Substring(1)) && RightToLeft(n.Substring(0, n.Length - 1));
        }
        private static bool LeftToRight(string n)
        {
            if (!primes.Contains(n))
                return false;
            else if (n.Length == 1 || results.Contains(int.Parse(n)))
                return true;
            else
                return LeftToRight(n.Substring(1));
        }
        private static bool RightToLeft(string n)
        {
            if (!primes.Contains(n))
                return false;
            else if (n.Length == 1 || results.Contains(int.Parse(n)))
                return true;
            else
                return RightToLeft(n.Substring(0, n.Length - 1));
        }
    }
}
