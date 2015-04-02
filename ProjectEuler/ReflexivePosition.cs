using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class ReflexivePosition
    {
        private static Queue<string> state = new Queue<string>();
        private static int i = 0;
        private static int o = 0;

        public static void Solve()
        {
            state.Enqueue("t");
            state.Enqueue("o");
            Console.WriteLine(state.ToString());
            Console.ReadKey();
        }
        public static int f(int n)
        {
            return 0;
        }
    }
}
