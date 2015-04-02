using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    //https://en-de.reddit.com/r/AskReddit/comments/2ifrmn/what_is_the_toughest_brainteaser_you_know_of/cl26mdm?context=10000
    class ClassGuessNumbers
    {
        public static bool Solve()
        {
            Random random = new Random();

            int classSize = 7;
            int[] studentNumbers = new int[classSize+1]; //using index of 8 for human readability (1-7 instead of 0-6)
            int[] studentGuesses = new int[classSize+1];
            for (int i = 1; i <= 7;i++ )
            {
                studentNumbers[i] = random.Next(8);
            }
            for (int i = 1; i <= classSize; i++)
            {
                int sumOfOtherStudents = 0;
                for (int j = 1; j <= classSize; j++)
                {
                    if (j != i)
                        sumOfOtherStudents += studentNumbers[j];
                }
                int step2 = i - sumOfOtherStudents;
                while (step2 < 0)
                {
                    step2 += classSize;
                }
                if (step2 == 0)
                    studentGuesses[i] = classSize;
                else
                    studentGuesses[i] = step2;
            }
            bool weGetPizza = false;
            for (int i = 1; i <= classSize; i++)
            {
                if (studentGuesses[i] == studentNumbers[i])
                {
                    weGetPizza = true;
                }
            }
            return weGetPizza;
            
        }
    }
}
