using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class LongestCollatz
    {
        static Dictionary<long, long> knownSequences;
        public static void Solve()
        {
            long max = 0;
            long maxSeed = 0;
            long temp;
            knownSequences = new Dictionary<long, long>();
            for (int i = 2; i < 1000000; i++)
            {
                temp = Collatz(i);
                if (temp > max)
                {
                    max = temp;
                    maxSeed = i;
                }
            }
            Console.WriteLine(maxSeed);
        }
        public static long Collatz(long n)
        {
            long count = 0;
            long original = n;
            while (n != 1)
            {
                if (knownSequences.ContainsKey(n))
                {
                    count += knownSequences[n];

                    break;
                }
                if (n % 2 == 0)
                {
                    n = n / 2;
                }
                else
                {
                    n = n * 3 + 1;
                }
                count++;
            }

            knownSequences.Add(original, count);
            return count;
        }
    }
}
