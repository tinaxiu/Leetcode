using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class _200
    {

        //[['1','1','1','1','1','1','1','1','1','1','1','1','1','1','1','0','0','1','1','1','1','1','1','1','1','1','1','1','1','1','1','1','1','1','1','1','1','1','1','1','1','1','0','0','0','0','1','1','1','1','1','1','1','1','1','1','1','1','1','1','1','1','1','1','1','1','1','1','1','1','1','1','1','1','1','1','1','1','1','1','1','1','1','1']]
        public void runCode()
        {
            char[][] grid = new char[1][];
            for(int i = 0; i <grid.Length; i++)
            {
                grid[i] = new char[4];
            }

            //char[] c1 = { '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '0', '0', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '0', '0', '0', '0', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1', '1' };
            //char[] c2 = { '1', '1', '0', '0', '0'};
            //char[] c3 = { '0', '0', '1', '0', '0' };
            //char[] c4 = { '0', '0', '0', '1', '1' };
            char[] c1 = { '1', '1', '1', '1', '0', '1', '1' };
            grid[0] = c1;
            //grid[1] = c2;
            //grid[2] = c3;
            //grid[3] = c4;


            NumIslands(grid);


        }


        int[] dX ={-1, 0, 1, 0};
        int[] dY = { 0, 1, 0, -1 };
        int lands = 0;
        public int NumIslands(char[][] grid)
        {
            
            for (int i = 0; i < grid.Length; i++)
                for (int j = 0; j < grid[0].Length; j++)
                {
                    if (grid[i][j] == '1')
                    {
                        findIsland(grid, i, j);
                        lands++;
                    }                      
                }
            return lands;
        }

        char [][] findIsland(char[][] grid,int i, int j)
        {
            
            for(int d = 0; d< dX.Length; d++)
            {
                if(i+dX[d] < grid.Length && i+dX[d] >=0 && j+dY[d] <grid[0].Length && j+dY[d] >=0)
                {
                    string pair = (i + dX[d]).ToString() +','+ (j + dY[d]).ToString() ;
                    if (grid[i + dX[d]][j + dY[d]] == '1')
                    {
                        grid[i + dX[d]][j + dY[d]] = '0';
                        findIsland(grid, i + dX[d], j + dY[d]);
                        
                    }
                }
            }

            return grid;
        }
    }
}
