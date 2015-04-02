using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class MyCalculator
    {
        public static void Solve()
        {
            List<int> n = new List<int>(new int[] { 9,9,9 }.Reverse());
            MyCalculator calc = new MyCalculator();
            calc.Add(new List<int>(new int[] { 9,9 }.Reverse()));
            calc.Add(n);
            calc.PrintState();
            Console.ReadKey();
        }
        private List<int> Digits;
        public MyCalculator()
        {
            Digits = new List<int>();
            Digits.Add(0);
        }
        public MyCalculator(List<int> init)
        {
            Digits = init;
        }
        public void Add(List<int> num)
        {
            int currSum = 0;
            int i = 0;
            for (i = 0; i < Digits.Count || i < num.Count; i++)
            {
                if (i < num.Count)
                {
                    if (Digits.Count == i)
                        Digits.Add(0);

                    currSum += num[i] + Digits[i];
                    Digits[i] = currSum % 10;
                    currSum -= Digits[i];
                    currSum /= 10;
                }
                else if (currSum > 0)
                {
                    currSum += Digits[i];
                    Digits[i] = currSum % 10;
                    currSum -= Digits[i];
                    currSum /= 10;
                }
            }
            while (currSum > 0)
            {
                Digits.Add(currSum % 10);
                currSum -= Digits[i];
                currSum /= 10;
                i++;
            }
            
        }
        public void Subtract(List<int> num)
        {

        }
        public void PrintState()
        {
            StringBuilder str = new StringBuilder();
            for (int i = Digits.Count - 1; i >= 0; i--)
            {
                str.Append(Digits[i]);
            }
            int result = int.Parse(str.ToString());
            Console.WriteLine(result.ToString("N0"));
        }

    }
}
