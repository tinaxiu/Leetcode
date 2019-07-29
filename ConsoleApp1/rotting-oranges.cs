using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{

    class rotting_oranges
    {
        int[] dr = new int[] { -1, 0, 1, 0 };
        int[] dc = new int[] { 0, -1, 0, 1 };

        public int OrangesRotting(int[][] grid)
        {
            int R = grid.Length, C = grid[0].Length;

            Queue<int> queue = new Queue<int>();
            Dictionary<int, int> depth = new Dictionary<int, int>();

            //Add all rotted orange in the queue
            for (int r=0; r<R; r++)
                for( int c =0; c<C; c++)
                {
                    if(grid[r][c] == 2)
                    {
                        int code = r * C + c;
                        queue.Enqueue(code);
                        depth.Add(code, 0);
                    }
                }

            int ans = 0;

            //take the rotted orange from the queue, check orange on all 4 directions,  and if the orange is fresh, change it to rotted
            while (queue.Count != 0)
            {
                int code = queue.Dequeue();
                int r = code / C, c = code % C;
                for (int k = 0; k<4; k++)
                {
                    int nr = r + dr[k];
                    int nc = c + dc[k];
                    if( 0<= nr && nr <R && 0<=nc&& nc< C && grid[nr][nc] ==1)
                    {
                        grid[nr][nc] = 2;
                        int ncode = nr * C + nc;
                        queue.Enqueue(ncode);
                        depth.Add(ncode, depth[code] + 1);
                        ans = depth[ncode];
                    }
                }
            }

            foreach (int[] row in grid)
            {
                foreach (int v in row)
                    if (v == 1)
                        return -1;
            }

            return ans;
        }

        public int OrangesRotting_practice(int[][] grid)
        {
            int[] dx = { -1, 0, 1, 0 };
            int[] dy = { 0, 1, 0, -1 };

            int ans = 0;
            int code = 0;
            Queue<int> queue = new Queue<int>();
            Dictionary<int, int> depth = new Dictionary<int, int>();

            for (int r = 0; r < grid.Length; r++)
                for(int c =0; c <grid[0].Length;)
                    if(grid[r][c] == 2)
                    {
                        code = r * grid[0].Length + c;
                        queue.Enqueue(code);
                        depth.Add(code, 0);
                    }
            while (queue.Count != 0)
            {
                int ncode = queue.Dequeue();
                int r = code / grid[0].Length;
                int c = code % grid[0].Length;

                for (int k = 0; k < 4; k++)
                    if (0 <= r + dx[k] && r + dx[k] < grid.Length && 0 <= c + dy[k] && c + dy[k] < grid[0].Length && grid[r + dx[k]][c + dy[k]]==1 )
                    {
                        grid[r + dx[k]][c + dy[k]] = 2;
                        depth.Add(ncode, depth[ncode] + 1);
                        ncode = (r + dx[k]) * grid[0].Length + c;
                        queue.Enqueue(ncode);
                        ans = depth[ncode];

                    }

             foreach(int[] row in grid)
            {
                    foreach (int v in row)
                        if (v == 1)
                            return -1;
                }

                
            }


            return ans;
        }
    }
}
