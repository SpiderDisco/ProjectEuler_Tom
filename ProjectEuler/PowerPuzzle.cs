using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    /*
     * https://www.youtube.com/watch?v=E5-pgBnGyzw
     * range of numbers can be divided into two parts. sum and sum of powers of both sets are equal.
     * n < 2^k+1
     */
    public static class PowerPuzzle
    {
        // _k is the exponent to be used
        private static int _k;
        // Range of numbers is 0 to _n
        private static int _n; 

        // 7 = (2^3)-1

        public static void Solve()
        {
            _k = 2;
            _n = (int)Math.Pow(2, _k + 1);

            List<int> a = new List<int>(); //{ 0, 3, 5, 6 };
            List<int> b = new List<int>(); //{ 1, 2, 4, 7 };

            GetLists(a, b);

            if (Done(a, b))
                Console.WriteLine("pass");
            else
                Console.WriteLine("fail");

        }
        private static void GetLists(List<int> a, List<int> b)
        {
            
            PrintArray(a);
            PrintArray(b);
        }
       
        private static bool Done(List<int> a, List<int> b)
        {
            return SumTest(a, b) && SumPowerTest(a, b);
        }
        private static bool SumTest(List<int> a, List<int> b)
        {
            Console.WriteLine("SumTest: {0} == {1}", a.Sum(), b.Sum());
            return a.Sum() == b.Sum();
        }
        private static bool SumPowerTest(List<int> a, List<int> b)
        {
            List<int> a2 = new List<int>();
            List<int> b2 = new List<int>();

            foreach (int n in a)
                a2.Add((int)Math.Pow(n, _k));

            foreach (int n in b)
                b2.Add((int)Math.Pow(n, _k));

            Console.WriteLine("SumPowerTest: {0} == {1}", a2.Sum(), b2.Sum());
            return a2.Sum() == b2.Sum();
        }

        private static void PrintArray(List<int> list)
        {
            Console.WriteLine(String.Join(", ", list.ToArray()));
        }
    }
}
