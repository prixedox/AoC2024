using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D04
{
    internal class GridAnalyzer
    {
        public int GetNumberOfXmas(string[] grid)
        {
            int totalCount = 0;
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[i].Length; j++)
                {
                    if (grid[i][j] == 'X')
                    {
                        totalCount += Get8DirectionCount(grid, [i, j]);
                    }
                }
            }
            return totalCount;
        }

        private int Get8DirectionCount(string[] grid, int[] pos)
        {
            int count = 0;

            int[][] directions = [[-1, 0], [1, 0], [0, -1], [0, 1], [-1, -1], [-1, 1], [1, -1], [1, 1]];

            string target = "XMAS";

            foreach (int[] direction in directions)
            {
                int[] actualPos = [pos[0], pos[1]];
                bool found = true;
                foreach (char c in target)
                {
                    if (!InBoundaries(actualPos, grid.Length))
                    {
                        found = false;
                        break;
                    }
                    if (grid[actualPos[0]][actualPos[1]] != c)
                    {
                        found = false;
                        break;
                    }

                    actualPos[0] += direction[0];
                    actualPos[1] += direction[1];
                }

                if (found)
                {
                    count++;
                }
            }

            return count;
        }

        private bool InBoundaries(int[] actualPos, int size)
        {
            if (actualPos[0] >= size || actualPos[1] >= size ||
                actualPos[0] < 0 || actualPos[1] < 0)
            {
                return false;
            }

            return true;
        }
    }
}
