using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class Program
    {
        static void Main(string[] args)
        {
            checked
            {
                //TruncatablePrimes.Solve();
                //AlternativeVote.Solve();
                //HttpTester.Request();

                //FirstTen.Sieve(400);
                //HundredToOne.Solve();
                SelfPowers.Solve();

                //LargeSum.Solve();
                //DataRead.Start();
            }
            Console.ReadKey();
        }
        public static List<int> DoPrimeCount(int count)
        {
            List<int> P = new List<int>();
            int n = 2;
            bool prime = true;
            while (P.Count < count)
            {
                foreach (int p in P)
                {
                    if ((double)n % p == 0)
                    {
                        prime = false;
                        break;
                    }
                }
                if (prime)
                {
                    P.Add(n);
                }
                else
                {
                    prime = true;
                }
                n++;
            }
            return P;
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
        public static List<int> SieveEratosthenes(int max,List<int> startingPoint)
        {
            bool[] N = new bool[max];
            for (int i = 0; i < N.Length; i++)
            {
                if(i>startingPoint.Last() || startingPoint.Contains(i))
                    N[i] = true;
                else
                    N[i] = false;
            }
            for (int i = startingPoint.Last(); i < N.Length; i++)
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
