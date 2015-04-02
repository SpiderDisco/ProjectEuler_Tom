using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class FirstTen
    {
        public static List<int> SieveAtkin(int max)
        {
            List<int> results = new List<int>(new int[]{2,3,5});

            List<int> group1 = new List<int>(new int[] { 1, 13, 17, 29, 37, 41, 49, 53 });
            List<int> group2 = new List<int>(new int[] { 7, 19, 31, 43 });
            List<int> group3 = new List<int>(new int[] { 11, 23, 47, 59 });
            
            bool[] N = new bool[max];
            for (int i = 0; i < max; i++)
                N[i] = false;
            N[2] = N[3] = true;
            
            for (int x = 1; x <= Math.Sqrt(max); x++)
            {
                for (int y = 1; y <= Math.Sqrt(max); y++)
                {
                    int n = (4 * x * x) + (y * y);
                    if (n <= max && (n % 12 == 1 || n % 12 == 5))
                    {
                        N[n] = !N[n];
                    }
                    
                    n = (3 * x * x) + (y * y);
                    if (n <= max && (n % 12 == 7))
                    {
                        N[n] = !N[n];
                    }
                    
                    n = (3 * x * x) - (y * y);
                    if (x > y && n <= max && (n % 12 == 11))
                    {
                        N[n] = !N[n];
                    }
                }
            }
            for (int n = 5; n < N.Length; n++)
            {
                if (N[n])
                {
                    if (!results.Contains(n))
                    {
                        results.Add(n);
                    }
                    int mult = n * n;
                    for (int i = mult; i < max; i += mult)
                    {
                        N[i] = false;
                    }
                }
            }
            return results;
        }
        public static void SumPrimes()
        {
            List<int> primes = SieveEratosthenes(2000000);
            long sum = 0;
            foreach (int n in primes)
            {
                sum += n;
            }
            Console.WriteLine(sum);
        }
        public static void SumSquareDiff()
        {
            int sumSquares = 0;
            int squareSum = 0;
            int n = 100;
            for (int i = 1; i <= n; i++)
                sumSquares += i * i;

            for (int i = 1; i <= n; i++)
                squareSum += i;
            squareSum *= squareSum;

            Console.WriteLine(sumSquares);
            Console.WriteLine(squareSum);
            Console.WriteLine(squareSum - sumSquares);
        }
        public static void LargestProductInSeries()
        {
            string str = "7316717653133062491922511967442657474235534919493496983520312774506326239578318016984801869478851843858615607891129494954595017379583319528532088055111254069874715852386305071569329096329522744304355766896648950445244523161731856403098711121722383113622298934233803081353362766142828064444866452387493035890729629049156044077239071381051585930796086670172427121883998797908792274921901699720888093776657273330010533678812202354218097512545405947522435258490771167055601360483958644670632441572215539753697817977846174064955149290862569321978468622482839722413756570560574902614079729686524145351004748216637048440319989000889524345065854122758866688116427171479924442928230863465674813919123162824586178664583591245665294765456828489128831426076900422421902267105562632111110937054421750694165896040807198403850962455444362981230987879927244284909188845801561660979191338754992005240636899125607176060588611646710940507754100225698315520005593572972571636269561882670428252483600823257530420752963450";
            string substr;
            int currProd = 1;
            int maxProd = 0;
            for (int i = 0; i < str.Length - 4; i++)
            {
                currProd = 1;
                substr = str.Substring(i, 5);
                foreach (char c in substr)
                {
                    currProd *= int.Parse(c + "");
                }
                if (currProd > maxProd)
                    maxProd = currProd;
            }
            Console.WriteLine(maxProd);
        }
        public static void SmallestMultiple()
        {
            int n = 10;
            bool done = false;
            bool fail = false;
            while (!done)
            {
                fail = false;
                for (int i = 1; i <= 20 && !fail; i++)
                {
                    if (n % i != 0)
                    {
                        fail = true;
                    }
                }
                if (!fail)
                {
                    done = true;
                }
                else
                {
                    n++;
                }
            }
            Console.WriteLine(n);
        }
        public static void Palindrome()
        {
            int n = 0;
            int m = -1;
            int k = -1;
            int max = 0;
            for (int i = 100; i <= 1000; i++)
            {
                for (int j = 100; j <= 1000; j++)
                {
                    if (isPalindrome2(i * j))
                    {
                        m = i;
                        k = j;
                        n = i * j;
                        if (n > max)
                            max = n;
                    }
                }
            }
            Console.WriteLine(max);
            Console.WriteLine(m);
            Console.WriteLine(k);
        }
        private static bool isPalindrome2(int n)
        {
            string str = n + "";
            bool result = true;
            int left = 0;
            int right = str.Length - 1;
            while (left < right && result)
            {
                result = str[left] == str[right];
                left++;
                right--;
            }
            return result;
        }
        private static bool isPalindrome(int n)
        {
            string str = n + "";
            int l = str.Length;
            string firstHalf = str.Substring(0, l / 2);

            string secondHalf;
            if (l % 2 == 0)
                secondHalf = str.Substring(l / 2);
            else
                secondHalf = str.Substring((l / 2) + 1);

            char[] secondHalfArray = secondHalf.ToCharArray();
            Array.Reverse(secondHalfArray);
            secondHalf = new string(secondHalfArray);

            return firstHalf == secondHalf;
        }
        public static void PrimeFactors()
        {
            long n = 600851475143;
            List<int> primes = SieveEratosthenes(500000);
            foreach (int p in primes)
            {
                if (n % p == 0)
                {
                    Console.WriteLine(p);
                }
            }

        }
        public static void EvenFibs()
        {
            //int l = 1;
            int m = 1;
            int n = 2;
            //int count=2;
            int sum = 2;
            while (n < 4000000)
            {
                n += m;
                m = n - m;
                //count++;
                if (n % 2 == 0)
                    sum += n;
            }
            Console.WriteLine(sum);
        }
        public static void ThreeAndFive()
        {
            int sum = 0;
            for (int i = 0; i < 1000; i++)
            {
                if (i % 3 == 0)
                    sum += i;
                else if (i % 5 == 0)
                    sum += i;
            }
            Console.WriteLine(sum);
        }
        public static List<int> SieveEratosthenes(int max)
        {
            bool[] N = new bool[max];
            for (int i = 0; i < N.Length; i++)
                N[i] = true;
            N[0] = N[1] = false;

            for (int i = 2; i < N.Length; i++)
            {
                if (N[i])
                {
                    for (int j = (2 * i); j < N.Length; j += i)
                    {
                        N[j] = false;
                    }
                }
            }
            List<int> result = new List<int>();
            for (int i = 0; i < N.Length; i++)
            {
                if (N[i])
                {
                    result.Add(i);
                }
            }
            return result;
        }
        public static void Sieve(int max, int goal = -1)
        {
            //int max = 1000000;
            int primesFound = 0;
            Stopwatch timer = new Stopwatch();
            bool[] N = new bool[max];
            for (int i = 0; i < N.Length; i++)
                N[i] = true;
            N[0] = N[1] = false;

            timer.Start();
            for (int i = 2; i < max; i++)
            {
                if (N[i])
                {
                    for (int j = (2 * i); j < max; j += i)
                    {
                        N[j] = false;
                    }
                }
            }
            for (int i = 2; i < max; i++)
            {
                if (N[i])
                {
                    primesFound++;
                    if (primesFound == goal)
                    {
                        Console.WriteLine(i);
                        //Console.ReadKey();
                    }
                }
            }
            if (goal == -1)
                Console.WriteLine(primesFound + " primes found");
            timer.Stop();
            Console.WriteLine(timer.Elapsed.ToString());
        }
        public static void DoPrimeCount(int count)
        {
            Stopwatch timer = new Stopwatch();
            List<int> P = new List<int>();
            int n = 1;
            bool prime = true;
            timer.Start();
            while (P.Count < count)
            {
                n++;
                foreach (int p in P)
                {
                    if ((double)n % p == 0)
                    {
                        prime = false;
                        break;
                    }
                }
                if (prime)
                {
                    P.Add(n);
                }
                else
                {
                    prime = true;
                }

            }
            timer.Stop();
            Console.WriteLine(n);
            Console.WriteLine(timer.Elapsed.ToString());
        }
        public static void PythagTrip1000()
        {
            int a;
            int b;
            int c;
            //int i = 0;
            for (int m = 0; m < 500; m++)
            {
                for (int n = 0; n < 500 && n < m; n++)
                {
                    a = m * m - n * n;
                    b = 2 * m * n;
                    c = m * m + n * n;
                    //Console.WriteLine(a + "," + b + "," + c);
                    //Console.WriteLine(m + "," + n);
                    //Console.WriteLine();
                    if (a + b + c == 1000)
                    {
                        Console.WriteLine(a + "," + b + "," + c);
                        Console.WriteLine(m + "," + n);
                        Console.WriteLine(a * b * c);
                        Console.ReadKey();
                    }
                }
            }

        }
    }
}
