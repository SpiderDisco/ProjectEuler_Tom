using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class LargeSum
    {
        public static void Solve()
        {

            string[] file = File.ReadAllLines(@"..\..\Files\largeSum.txt");
            int length = 50;
            int[] rowSums = new int[length];
            ulong sum = 0;
            for (int i = 0; i < length; i++)
            {
                foreach (string n in file)
                {
                    rowSums[i] += int.Parse(n.ToCharArray()[i]+"");
                }
            }
            int power = 0;
            for (int i = 0; i < length/2; i++)
            {
                Console.WriteLine(rowSums[i] * (long)Math.Pow(10, power));
                sum += (ulong)(rowSums[i] * (long)Math.Pow(10, power));
                power--;
            }

            
            for (int i = length/2; i < length; i++)
            {
                Console.WriteLine(rowSums[i] * (long)Math.Pow(10, power));
                sum += (ulong)(rowSums[i] * (long)Math.Pow(10, power));
                power++;
            }

            Console.WriteLine(sum);

        }
    }
}
