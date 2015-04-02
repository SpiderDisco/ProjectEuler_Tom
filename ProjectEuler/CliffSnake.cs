using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    //https://www.youtube.com/watch?v=pFHsrCNtJu4
    class CliffSnake
    {
        static int pos, step;
        static int[] moves;
        static SolutionContainer solutions;
        public static void Solve()
        {
            solutions = new SolutionContainer();
            pos = 0;
            step = 1;
            moves = new int[] { int.MinValue, 1, -1,- 1, 1, 1, -1, -1, 1, 1, -1, -1, 1 };

            Execute();
            Console.ReadKey();
        }
        public static bool Alive()
        {
            return pos < 2 && pos > -2;
        }
        public static void Execute()
        {
            if (moves.Length != 13)
            {
                Console.WriteLine("not 12 steps");
                return;
            }
            for(int i=step;i<=12;i+=step)
            {
                pos += moves[i];
                if (!Alive())
                {
                    Console.WriteLine("dead");
                    break;
                }
            }
            if (Alive())
            {
                Console.WriteLine("Alive");
                
            }
        }
    }
    public class SolutionContainer
    {
        private List<Solution> Solutions;
        public SolutionContainer()
        {
            Solutions = new List<Solution>();
        }
        public bool Contains(Solution s)
        {
            return Solutions.Contains(s);
        }
        public void Add(Solution s)
        {
            if (!Solutions.Contains(s))
                Solutions.Add(s);
            else
            {
                int index = Solutions.IndexOf(s);
                Solutions[index].AddNumbers(s.NumbersSolved);
            }
        }
    }
    public class Solution : IEquatable<Solution>
    {
        public List<int> NumbersSolved;
        private int[] Instructions;
        public Solution()
        {
            NumbersSolved = new List<int>();
        }
        public void AddNumber(int n)
        {
            if(!NumbersSolved.Contains(n))
                NumbersSolved.Add(n);
        }
        public void AddNumbers(List<int> nums)
        {
            foreach (int n in nums)
            {
                AddNumber(n);
            }
        }
        public static bool operator ==(Solution s1, Solution s2)
        {
            if (s1.Instructions.Length != s2.Instructions.Length)
                return false;
            for (int i = 1; i < s1.Instructions.Length; i++)
            {
                if (s1.Instructions[i] != s2.Instructions[i])
                    return false;
            }
            return true;
        }
        public bool Equals(Solution s2)
        {
            if (Instructions.Length != s2.Instructions.Length)
                return false;
            for (int i = 1; i < Instructions.Length; i++)
            {
                if (Instructions[i] != s2.Instructions[i])
                    return false;
            }
            return true;
        }
        public override bool Equals(System.Object o)
        {
            Solution s2 = o as Solution;
            if (Instructions.Length != s2.Instructions.Length)
                return false;
            for (int i = 1; i < Instructions.Length; i++)
            {
                if (Instructions[i] != s2.Instructions[i])
                    return false;
            }
            return true;
        }
        public static bool operator !=(Solution a, Solution b)
        {
            return !(a == b);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
