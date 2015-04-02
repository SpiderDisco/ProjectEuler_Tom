using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class DigitFifthPowers
    {
        public static void Solve()
        {
            string n;
            int sum;
            List<int> result = new List<int>();
            for (int i = 2; i < 999999; i++)
            {
                n = i + "";
                sum = 0;
                foreach (char c in n.ToCharArray())
                {
                    try
                    {
                        sum += checked((int)Math.Pow(int.Parse(c + ""), 5));
                    }
                    catch (OverflowException e)
                    {
                        Console.WriteLine(e.ToString());
                    }
                }
                if (sum == i)
                {
                    result.Add(i);
                }
            }
            Console.WriteLine(String.Join(",", result));
            Console.WriteLine(result.Sum());
            Console.ReadKey();
        }
    }
}
