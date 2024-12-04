using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D04
{
    internal class GridAnalyzer2
    {
        public int GetNumberOfXmas(string[] grid)
        {
            int totalCount = 0;
            for (int i = 1; i < grid.Length - 1; i++)
            {
                for (int j = 1; j < grid[i].Length - 1; j++)
                {
                    if (grid[i][j] == 'A')
                    {
                        if (IsXmas(grid, [i, j]))
                        {
                            totalCount++;
                        }
                    }
                }
            }
            return totalCount;
        }

        private bool IsXmas(string[] grid, int[] pos)
        {
            int[] upperLeft = [pos[0] - 1, pos[1] - 1];
            int[] upperRight = [pos[0] - 1, pos[1] + 1];
            int[] lowerLeft = [pos[0] + 1, pos[1] - 1];
            int[] lowerRight = [pos[0] + 1, pos[1] + 1];

            if (!((grid[upperLeft[0]][upperLeft[1]] == 'M' && grid[lowerRight[0]][lowerRight[1]] == 'S') ||
                (grid[upperLeft[0]][upperLeft[1]] == 'S' && grid[lowerRight[0]][lowerRight[1]] == 'M')))
            {
                return false;
            }
            if (!((grid[upperRight[0]][upperRight[1]] == 'M' && grid[lowerLeft[0]][lowerLeft[1]] == 'S') ||
                (grid[upperRight[0]][upperRight[1]] == 'S' && grid[lowerLeft[0]][lowerLeft[1]] == 'M')))
            {
                return false;
            }

            return true;
        }

    }
}
