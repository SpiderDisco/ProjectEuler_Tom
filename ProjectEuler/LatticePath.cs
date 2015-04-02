using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class LatticePath
    {
        private static long numPaths;
        private static int size;
        public static void Solve()
        {
            numPaths = 0;
            size = 20;
            Move(0, 0);
            Console.WriteLine(numPaths);
        }
        public static void Move(int x, int y)
        {
            if (x == size && y == size)
            {
                numPaths++;
                return;
            }
            if (x < size)
            {
                Move(x+1, y);
            }
            if (y < size)
            {
                Move(x, y+1);
            }
        }
    }
}
