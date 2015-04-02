using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class BouncyNumbers
    {
        public static void Solve()
        {
            int n = int.MaxValue;
            int count = 0;
            double proportion = 0;
            double difference = 0;

            for (int i = 0; i < n; i++)
            {
                if (IsBouncy(i))
                    count++;
                proportion = (double)count / i;
                if (proportion >= .99)
                {
                    difference = Math.Abs(proportion - .99);
                    if (difference <= .0001)
                    {
                        Console.WriteLine(i + ", " + proportion);
                        //break;
                    }
                }


            }


            //Console.WriteLine(proportion);
            //Console.WriteLine(count);

        }

        public static bool IsBouncy(int n)
        {
            if (n < 100)
                return false;

            return !(IsIncreasing(n) || IsDecreasing(n));
        }
        public static bool IsIncreasing(int n)
        {
            string str = "" + n;
            int previous = -1;

            foreach (char c in str.ToCharArray())
            {
                if (int.Parse(c + "") < previous)
                    return false;
                previous = int.Parse(c + "");
            }

            return true;
        }
        public static bool IsDecreasing(int n)
        {
            string str = "" + n;
            int previous = int.MaxValue;

            foreach (char c in str.ToCharArray())
            {
                if (int.Parse(c + "") > previous)
                    return false;
                previous = int.Parse(c + "");
            }

            return true;
        }
    }
}
