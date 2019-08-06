using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class _48
    {
        public void rotate(int[][] matrix)
        {
            int n = matrix.Length - 1;
            for (int i = 0; i <= n; i++)
                for (int j = 0; j <= n; j++)
                {
                    int temp = matrix[i][j];
                    matrix[i][j] = matrix[n - j][i];
                    matrix[n - j][i] = matrix[n - i][n - j];
                    matrix[n - i][n - j] = matrix[j][n - i];
                    matrix[j][n - i] = temp;
                }
        }
    }
}