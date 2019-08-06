using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class _200
    {
        public void runCode()
        {
            char[][] grid = new char[5][];
            for(int i = 0; i <grid.Length; i++)
            {
                grid[i] = new char[4];
            }

            char[] c1 = { '1', '1', '1', '1', '0' };
            char[] c2 = { '1', '1', '0', '1', '0'};
            char[] c3 = { '1', '1', '0', '0', '0' };
            char[] c4 = { '0', '0', '0', '0', '0' };
            grid[0] = c1;
            grid[1] = c2;
            grid[2] = c3;
            grid[4] = c4;


            NumIslands(grid);


        }

        List<char[]> isleand = new List<char[]>();

        int[] dX ={-1, 0, 1, 0};
        int[] dY = { 0, 1, 0, -1 };
        int lands = 0;
        public int NumIslands(char[][] grid)
        {
            


            int i = 0, j = 0;
           
            
            while (i < grid.Length)
                while (j < grid[0].Length)
                {
                    if (grid[i][j] == '1')
                    {
                        island.Add(new KeyValuePair<int, int>(i, j));
                        findIsland(grid, i, j);
                        lands++;
                        grid = islandToWater(grid);

                    }                   
                }
            return lands;
        }

        char[][] islandToWater(char [][] grid)
        {
            for(int i = 0; i < grid.Length; i++)
                for(int j =0; j <grid[0].Length; j++)
                {
                    KeyValuePair<int, int> pair = new KeyValuePair<int, int>(i, j);
                    if (island.Contains(pair))
                    {
                        grid[i][j] = '0';
                        island.Remove(pair);
                    }
                }
            return grid;
                    
        }

        void findIsland(char[][] grid,int i, int j)
        {
            
            for(int d = 0; d< dX.Length; d++)
            {
                if(i+dX[d] < grid.Length && i+dX[d] >=0 && j+dY[d] <grid[0].Length && j+dY[d] >=0)
                {
                    char[] pair = new char { i + dX[d], j + dY[d] };
                    if (grid[i + dX[d]][j + dY[d]] == 1 && !island.Contains(pair))
                    {
                        island.Add(pair);
                        findIsland(grid, i + dX[d], j + dY[d]);
                    }
                }
            } 
        }
    }
}
