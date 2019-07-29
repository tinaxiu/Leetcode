using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Partition_Labels
    {

        public void runCode()
        {
            string S = "abccaddbeffe";
            PartitionLabels(S);
        }
        public IList<int> PartitionLabels(string S)
        {
            int[] last = new int[26];
            for (int i = 0; i<S.Length; i++)
            {
                last[S[i] - 'a'] = i;
            }

            int right = 0, left = 0;
            List<int> ans = new List<int>();
            for(int i = 0; i<S.Length; i++)
            {
                right = Math.Max(right, last[S[i] - 'a']);
                if(i == right)
                {
                    ans.Add(i-left+1);
                    left = i + 1;
                }

            }
            return ans;
        }
    }
}
