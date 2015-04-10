using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    //http://www.thousandtyone.com/blog/EasierThanFizzBuzzWhyCantProgrammersPrint100To1.aspx
    class HundredToOne
    {
        public static void Solve()
        {
            for(int i=0;i<100;i++)
            {
                Console.WriteLine(100 - i);
            }
        }
    }
}
