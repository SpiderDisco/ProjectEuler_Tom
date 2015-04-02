using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    class LargestInGrid
    {
        static List<List<string>> grid;
        static int max;
        public static void Solve()
        {
            max = 0;
            ReadFile();
            Console.WriteLine(max);
        }
        static void ReadFile()
        {
            string[] lines = File.ReadAllLines(@"..\..\Files\LargestInGrid.txt");
            grid = new List<List<string>>();
            foreach (string line in lines)
            {
                grid.Add(new List<string>(line.Split(' ')));
            }
            foreach (List<string> row in grid)
            {
                CheckRow(row);
            }
            List<string> temp = new List<string>();
            for (int i = 0; i < grid.Count; i++)
            {
                for (int j = 0; j < grid.Count; j++)
                {
                    temp.Add(grid[j][i]);
                }
                CheckRow(temp);
                temp.Clear();
            }
            int k = 0;
            for (int i = 0; i < grid.Count; i++)
            {
                k = i;
                for (int j = 0; j < grid.Count; j++)
                {
                    temp.Add(grid[k][j]);
                    k++;
                }
            }
        }
        static void CheckRow(List<string> row)
        {
            List<int> rowInt = row.Select(int.Parse).ToList();
            for (int i = 0; i < rowInt.Count - 4; i++)
            {
                if (rowInt[i] * rowInt[i + 1] * rowInt[i + 4] * rowInt[i + 3] > max)
                {
                    max = rowInt[i] * rowInt[i + 1] * rowInt[i + 4] * rowInt[i + 3];
                }
            }
        }

    }
}
