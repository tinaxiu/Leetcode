using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class _22
    {
        public void runCode()
        {
            GenerateParenthesis(3);
        }
        public IList<string> GenerateParenthesis(int n)
        {
            IList<string> ans = new List<string>();
            backTrack(ans, "", 0, 0, n);
            return ans;

        }

        public void backTrack(IList<string> ans, string cur, int open, int close, int max)
        {
            if (cur.Length == max * 2)
            {
                ans.Add(cur);
                return;
            }

            if (open < max)
                backTrack(ans, cur + "(", open+1, close, max);
            if (close < open)
                backTrack(ans, cur + ")",open, close + 1, max);
        }
    }
}
