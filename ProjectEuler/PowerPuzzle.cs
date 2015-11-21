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
     * 
     */
    public static class PowerPuzzle
    {
        private static int _pow;
        public static void Solve()
        {
            _pow = 2;
            List<int> a = new List<int> { 0, 3, 5, 6 };
            List<int> b = new List<int> { 1, 2, 4, 7 };

            if (Done(a, b))
                Console.WriteLine("pass");
            else
                Console.WriteLine("fail");

        }
        private static bool Done(List<int> a, List<int> b)
        {
            return SumTest(a, b) && SumPowerTest(a, b);
        }
        private static bool SumTest(List<int> a, List<int> b)
        {
            return a.Sum() == b.Sum();
        }
        private static bool SumPowerTest(List<int> a, List<int> b)
        {
            List<int> a2 = new List<int>();
            List<int> b2 = new List<int>();

            foreach (int n in a)
                a2.Add((int)Math.Pow(n, _pow));

            foreach (int n in b)
                b2.Add((int)Math.Pow(n, _pow));

            return a2.Sum() == b2.Sum();
        }
    }
}
