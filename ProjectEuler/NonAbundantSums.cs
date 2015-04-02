using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class NonAbundantSums
    {
        static List<int> NonAbundantSumsList;
        static List<int> AbundantNumbers;
        public static void Solve()
        {
            NonAbundantSumsList = new List<int>();
            AbundantNumbers = new List<int>();
            bool found;
            for (int i = 1; i <= 28123; i++)
            {
                found = false;
                if (IsAbundant(i))
                {
                    AbundantNumbers.Add(i);
                }
                foreach (int n in AbundantNumbers)
                {
                    if (AbundantNumbers.Contains(i - n))
                    {
                        found = true;
                        break;
                    }
                }
                if (!found)
                {
                    NonAbundantSumsList.Add(i);
                }
                
            }
            Console.WriteLine(NonAbundantSumsList.Sum());
            Console.WriteLine("done");
            Console.ReadKey();
        }
        
        private static bool IsAbundant(int n)
        {
            return GetDivisors(n).Sum() > n;
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
    }
}
