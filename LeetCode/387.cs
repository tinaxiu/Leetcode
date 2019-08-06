using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class _387
    {
        public int FirstUniqChar(string s)
        {
            Dictionary<char,int> map = new Dictionary<char, int>();
            int res = 0;
            for(int i = 0; i<s.Length; i++)
            {
                if(!map.ContainsKey(s[i]))
                {
                    map.Add(s[i], 1);
                }
                else
                {
                    map[s[i]] ++;
                }
            }

            foreach(KeyValuePair<char,int> pair in map)
            {
                if (pair.Value == 1)
                    return s.IndexOf(pair.Key);
            }
            return -1;
        }
    }
}
