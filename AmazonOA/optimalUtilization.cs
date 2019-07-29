using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class optimalUtilization
    {
        public void runCode()
        {
        }

        public List<List<int>> OU(int[,] A, int[,] B, int K)
        {
            List<List<int>> ans = new List<List<int>> ();
            if (A == null || A.Length == 0 || B == null || B.Length == 0)
            {
                
                return ans;
            }
                
            int maxSum = 0;
            
            for (int i =0; i<A.Length; i++)
            {
                for (int j =0; j<B.Length; j++)

                {
                    if ( A[i,1] + B[j, 1] > maxSum && A[i, 1] + B[j, 1] <= K)
                    {
                        maxSum = A[i, 1] + B[j, 1];
                        ans.Clear();
                        ans.Add(new List<List<int>>{i, j});
                    }
                    else if(A[i, 1] + B[j, 1] == maxSum)
                    {
                        ans.Add(new Tuple<int, int>(i, j));
                    }
                }
            }

            return ans;


        }
        public int[] optimal_Utilization(int[] A, int[] B, int K)
        {
            
            if (A == null || A.Length == 0 || B == null || B.Length == 0)
                return new int[0];

            int[] ans = new int[2];

            int indexA = 0;
            int indexB = 0;

            int currSum = 0;

            for (int i =0; i<A.Length; i++)
            {               
                for(int j =0; j< B.Length; j++)
                {
                    if(A[i] + B[j] == K)
                    {
                        return new int[] { i, j };
                    }
                    else if(A[i] + B[j] <K)
                    {
                        if (A[i] + B[j] > currSum)
                        {
                            indexA = i;
                            indexB = j;
                            currSum = A[indexA] + B[indexB];
                        }
                    }
                }
            }
            return new int[] { indexA, indexB };
        }
    }
}
