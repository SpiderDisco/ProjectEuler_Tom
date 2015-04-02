using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class ProductMatrix
    {
        public static void Solve()
        {
            Console.WriteLine(Convert.ToString(5, 2));

            Dictionary<char, int> counts = new Dictionary<char, int>();
            int b = 10;
            for (int i = 0; i < b; i++)
            {
                counts.Add(Convert.ToString(i).ToCharArray()[0],0);
            }
            int count = 0;
            string str="";
            using (StreamWriter file = new StreamWriter(@"..\..\Files\products.txt"))
            {
                for (int i = 10; i < 1000; i++)
                {
                    for (int j = 10; j < 1000; j++)
                    {
                        try
                        {
                            str = checked(Convert.ToString(i*j,b)) + "";
                        }
                        catch (OverflowException e)
                        {
                            Console.WriteLine(e.ToString());
                        }
                        
                        file.Write(str.ToCharArray()[0]);
                        counts[str.ToCharArray()[0]]++;
                        count++;
                    }
                    file.WriteLine();
                }
            }
            Console.WriteLine("Total: {0}", count);
            for (int i = 1; i < b; i++)
            {
                Console.WriteLine("{0}: {1}\t{2:P}", i, counts[Convert.ToString(i,b).ToCharArray()[0]], (double)counts[Convert.ToString(i,b).ToCharArray()[0]] / count);
            }
                Console.WriteLine("Done");
            Console.ReadKey();
        }
    }
}
