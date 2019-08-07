using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class _17
    {
        public void runCode()
        {
            LetterCombinations("78");
        }

        IList<string> res = new List<string>();
        Dictionary<string, string> map = new Dictionary<string, string>()
        { {"2","abc" }, { "3" , "def"},
          { "4","ghi"}, {"5","jkl" },
            { "6","mno"},{ "7", "pqrs"},
            { "8","tuv"},{ "9","wxyz" } };
        public IList<string> LetterCombinations(string digits)
        {
            if (digits.Length != 0)
                recursive("", digits);
            return res;
        }

        void  recursive(string comb, string next)
        {
            if (next.Length == 0)
                res.Add(comb);
            else
            {
                string d = next.Substring(0, 1);
                string l = map[d];
                for (int i = 0; i<l.Length; i++)
                {
                    string letter = map[d].Substring(i, 1);
                    recursive(comb + letter, next.Substring(1));
                }
            }          
        }


    }
}
