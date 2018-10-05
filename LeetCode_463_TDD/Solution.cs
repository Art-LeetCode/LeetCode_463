using System;

namespace LeetCode_463_TDD
{
    public class Solution
    {
        public int IslandPerimeter(int[,] grid)
        {
            var total = 0;
            for (int x = 0; x < grid.GetLength(0); x++)
            {
                for (int y = 0; y < grid.GetLength(1); y++)
                {
                    var result = GetUnitPerimeter(grid, x, y);
                    total = total + result;
                }
            }
            return total;
        }

        private int GetUnitPerimeter(int[,] grid, int x, int y)
        {
            var currectUnit = grid[x, y];
            if (currectUnit != 1) return 0;

            const int maxLength = 4;
            var north = CheckNorth(grid, x, y);
            var south = CheckSouth(grid, x, y);
            var west = CheckWest(grid, x, y);
            var east = CheckEast(grid, x, y);
            var currectPerimeter = maxLength - north - south - west - east;
            return currectPerimeter;
        }

        private int CheckEast(int[,] grid, int x, int y)
        {
            var isExistElement = y < grid.GetLength(1) - 1;
            return !isExistElement ? 0 : grid[x, y + 1];
        }

        private int CheckWest(int[,] grid, int x, int y)
        {
            var isExistElement = y - 1 >= 0;
            return !isExistElement ? 0 : grid[x, y - 1];
        }

        private int CheckSouth(int[,] grid, int x, int y)
        {
            var isExistElement = x < grid.GetLength(0) - 1;
            return !isExistElement ? 0 : grid[x + 1, y];
        }

        private int CheckNorth(int[,] grid, int x, int y)
        {
            var isExistElement = x > 0;
            return !isExistElement ? 0 : grid[x - 1, y];
        }
    }
}