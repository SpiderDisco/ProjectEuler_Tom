using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace ProjectEuler
{
    //https://projecteuler.net/problem=13
    class LargeSum
    {
        public static void Solve()
        {

            string[] file = File.ReadAllLines(@"..\..\Files\largeSum.txt");
            BigInteger sum = new BigInteger(0);

            foreach (string n in file)
            {
                sum += new BigInteger(n, 10);
            }

            Console.WriteLine(sum);

        }
    }
}
