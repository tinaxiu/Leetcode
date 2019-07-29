using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class MinimumCosttoMergeStones
    {
        public int RunMergeStone()
        {
            int[] Stones = new int[4];
            Stones[0] = 3;
            Stones[1] = 2;
            Stones[2] = 4;
            Stones[3] = 1;

            return MergeStones(Stones, 2);
        }
        public int MergeStones(int[] stones, int K)
        {
            int n = stones.Length;
            if ((n - 1) % (K - 1) != 0) return -1;
            int[] sums = new int[n + 1];
            int[,] dp = new int[n, n];

            sums[0] = 0;
            for (int i = 1; i < n + 1; ++i)
            {
                sums[i] = sums[i - 1] + stones[i - 1];
            }

            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    dp[i, j] = 0;

            for (int len = K; len <= n; ++len)
            {
                for (int i = 0; i + len <= n; ++i)
                {
                    int j = i + len - 1;
                    dp[i,j] = int.MaxValue;
                    for (int t = i; t < j; t += K - 1)
                    {
                        dp[i,j] = Math.Min(dp[i,j], dp[i,t] + dp[t + 1,j]);
                    }
                    if ((j - i) % (K - 1) == 0)
                    {
                         dp[i,j] += sums[j + 1] - sums[i];
                    }
                }
            }
            return dp[0,n - 1];
        }
    }
}
