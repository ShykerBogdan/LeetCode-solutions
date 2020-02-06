using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Medium
{
    public class NumberOfIslands
    {
        public int perimeter=0;
        public int IslandPerimeter(char[][] grid)
        {
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[i].Length; j++)
                {
                    if (grid[i][j] == '1')
                        CalculateBorders(i, j, grid);
                }
            }
            return 0;
        }

        public void CalculateBorders(int i, int j, char[][] grid)
        {
            if (i > 0 && grid[i - 1][j] == '0')
            {
                perimeter++;
            }
            if (j > 0 && grid[i][j - 1] == '0')
            {
                perimeter++;

            }
            if (i < grid.Length - 1 && grid[i + 1][j] == '0')
            {
                perimeter++;

            }
            if (j < grid.Length - 1 && grid[i][j + 1] == '0')
            {
                perimeter++;
            }
            if (i == 0 ||i==grid.Length-1)
            {
                perimeter++;
            }
            if (j == 0 || j == grid.Length - 1)
            {
                perimeter++;
            }
        }
        public void Test()
        {
            var map = new char[][]
            {
                new char [] {'0', '1', '0', '0' },
                new char [] {'1', '1', '1', '0'  },
                new char [] {'0', '1', '0', '0' },
                new char [] {'1', '1', '0', '0' }
            };

            IslandPerimeter(map);
        }

    }
}
