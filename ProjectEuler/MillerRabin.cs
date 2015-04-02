using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class MillerRabin
    {
        public static void Solve()
        {
            List<int> primes = FirstTen.SieveEratosthenes(10000);
            bool fail = false;
            foreach (int p in primes)
            {
                if (!IsPrime(p, 4000))
                {
                    Console.WriteLine(p);
                    fail = true;
                }
            }
            if (!fail)
            {
                Console.WriteLine("success");
            }

        }
        public static bool IsPrime(int n, int k)
        {
            if (n < 2)
            {
                return false;
            }
            if (n != 2 && n % 2 == 0)
            {
                return false;
            }
            int s = n - 1;
            while (s % 2 == 0)
            {
                s >>= 1;
            }
            Random r = new Random();
            for (int i = 0; i < k; i++)
            {
                double a = r.Next((int)n - 1) + 1;
                int temp = s;
                int mod = (int)Math.Pow(a, (double)temp) % n;
                while (temp != n - 1 && mod != 1 && mod != n - 1)
                {
                    mod = (mod * mod) % n;
                    temp = temp * 2;
                }
                if (mod != n - 1 && temp % 2 == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
