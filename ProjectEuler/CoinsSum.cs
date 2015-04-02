//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ProjectEuler
//{
//    class CoinsSum
//    {
//        static List<Wallet> solutions;
//        static int goal;
//        public static void Solve()
//        {
//            solutions = new List<Wallet>();
//            goal = 200;

//        }

//        private static bool Add1P(Wallet w)
//        {
//            w.p1++;
//            w.total += 1;
//        }
//        private static bool Add2P(Wallet w)
//        {
//            w.p2++;
//            w.total += 2;
//        }
//        private static bool Add5P(Wallet w)
//        {
//            w.p5++;
//            w.total += 5;
//        }
//        private static bool Add10P(Wallet w)
//        {
//            w.p10++;
//            w.total += 10;
//        }
//        private static bool Add20(Wallet w)
//        {
//            w.p20++;
//            w.total += 20;
//        }
//        private static bool Add50P(Wallet w)
//        {
//            w.p50++;
//            w.total += 50;
//        }
//        private static bool Add100P(Wallet w)
//        {
//            w.p100++;
//            w.total += 100;
//        }
//        private static bool Add200P(Wallet w)
//        {
//            if (w.total + 200 >= goal)
//            {
//                w.p200++;
//                w.total += 200;
//            }

//            return false;
//        }
//    }
//    class Wallet
//    {
//        public int p1;
//        public int p2;
//        public int p5;
//        public int p10;
//        public int p20;
//        public int p50;
//        public int p100;
//        public int p200;
//        public int total;

//        public Wallet()
//        {
//            p1 = 0;
//            p2 = 0;
//            p5 = 0;
//            p10 = 0;
//            p20 = 0;
//            p50 = 0;
//            p100 = 0;
//            p200 = 0;
//            total = 0;
//        }

//        public Wallet GetClone()
//        {
//            return new Wallet { p1 = p1, p2 = p2, p5 = p5, p10 = p10, p20 = p20, p50 = p50, p100 = p100, p200 = p200, total = total };
//        }
//    }
//}
