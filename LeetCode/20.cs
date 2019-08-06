using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class _20
    {
        public void runCode()
        {
            string s = "";
            IsValid(s);
        }
        public bool IsValid(string s)
        {
            Dictionary<char, char> map = new Dictionary<char, char>
            {
                {'[',']' },
                {'{', '}'},
                {'(',')' },
                { ')','('},
                { '}','{'},
                { ']','['}
            };
            if (s == "") return true;
            if (s.Length <2 ||s.Length % 2 != 0) return false;

            List<char> list = new List<char>();
            foreach (char c in s)
                list.Add(c);

            int i = 0;
            while (i+1<list.Count && i>=0)
            {
                if (map[list[i]] == list[i + 1])
                {
                    list.RemoveRange(i, 2);
                    if(i!=0)
                        i--;
                }
                    
                else
                    i++;
            }
            if (list.Count == 0)
                return true;
            else
                return false;
        }
    }
}
