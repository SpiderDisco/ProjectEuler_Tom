using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectEuler
{
    class Amicable
    {
        public static void Solve()
        {
            int[] DivisorSums = new int[10001];
            bool[] IsChecked = new bool[10001];
            int sum = 0;
            DivisorSums[0] = 0;
            for (int i = 1; i <= 10000; i++)
            {
                DivisorSums[i] = GetDivisors(i).Sum();
                IsChecked[i] = false;
            }
            for (int i = 1; i <= 10000; i++)
            {
                if (!IsChecked[i] && DivisorSums[i] < 10000 && DivisorSums[i] != i && DivisorSums[DivisorSums[i]] == i)
                {
                    sum += i;
                    sum += DivisorSums[i];
                    IsChecked[DivisorSums[i]] = true;
                    Console.WriteLine("d({0})={1} and d({1})={0}",i,DivisorSums[i]);
                }
                IsChecked[i] = true;
            }
            Console.WriteLine(sum);
            Console.WriteLine("done");
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
    }
}
