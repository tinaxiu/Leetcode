using System;
using System.Collections.Generic;
using System.Text;

//解法1：BFS.
//注意：

//此题类似骑士遍历题，但骑士遍历题的检查target是检查坐标，这题是检查value。所以如果在struct Point里面加上value这一项要确保target = 2的值没有被改掉。
//此题不需要visited map，因为可以简单的将targetMap[i][j] 设为1，这样下次就不用再访问了。
//In the validPlace(), 要确保先检查p.x和p.y的范围，然后再检查grid[p.x][p.y] 的值，不然就segment fault.
// --------------------- 
//作者：青灯照壁夜读书
// 来源：CSDN
// 原文：https://blog.csdn.net/roufoo/article/details/84693302 
//版权声明：本文为博主原创文章，转载请附上博文链接！

namespace ConsoleApp1
{
    class Shortest_path_AMOA
    {
        public struct Point
        {
            public int x;
            public int y;
            public Point(int row, int coll)
            {
                x = row;
                y = coll;
            }
        } 

        public void runCode()
        {
            int[,] targetMap = new int[,]
            {
                { 0, 0, 0},
                { 0,0,1},
                {0,0,2 }
            };

            shortestPath(targetMap);
        }

        int shortestPath( int [,] targetMap)
        {
            int[] dirX = { 1, 0, -1, 0 };
            int[] dirY = { 0, -1, 0, 1 };
          
            Queue<Point> q = new Queue<Point>();
            q.Enqueue(new Point(0, 0));
            int pathLen = 0;

            while(q.Count != 0)
            {
                int qSize = q.Count;
                for(int i=0; i<qSize; i++)
                {
                    Point p = q.Dequeue();

                    if (targetMap[p.x, p.y] == 2) return pathLen;

                    targetMap[p.x, p.y] = 1;
                    
                    for (int j =0; j<4; j++)
                    {
                        Point node = new Point(p.x + dirX[j], p.y + dirY[j]);
                        if (validPlace(targetMap, node))
                            q.Enqueue(node);
                    }
                }

                pathLen++;
               
            }
            return -1;
        }

        bool validPlace(int[,] grid, Point p)
        {
            if (p.x >= 0 && p.x < grid.Length &&
                p.y >= 0 && p.y < grid.Length &&
                grid[p.x, p.y] >= 0 &&
                grid[p.x, p.y] != 1)

                return true;
            else
                return false;
        }
    }
}
