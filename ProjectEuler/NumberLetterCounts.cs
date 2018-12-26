using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    //https://projecteuler.net/problem=17
    public class NumberLetterCounts
    {
        public static void Solve()
        {

        }
        static int getCount(int n)
        {
            int result = 0;
            switch(n)
            {
                case 1:
                case 2:
                case 6:
                case 10:
                    result = 3;
                    break;
                case 4:
                case 5:
                case 9:
                    result = 4;
                    break;
                case 7:
                case 8:
                    result = 5;
                    break;
                case 11:
                case 12:
                    result = 6;
                    break;
            }
            return result;
        }
    }
}
