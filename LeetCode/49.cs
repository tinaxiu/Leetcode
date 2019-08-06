using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    class _49
    {
        public void runCode()
        {
            string[] strs = new string[] { "eat", "tea", "tan", "ate", "nat", "bat" };
            GroupAnagrams(strs);
        }
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            Dictionary<string,List<string>> map = new Dictionary<string, List<string>>(); 
            foreach(string str in strs)
            {

                string key = String.Concat(str.OrderBy(c => c));
                if (map.ContainsKey(key))
                    map[key].Add(str);
                else
                {
                    map.Add(key, new List<string>() { str});
                }
            }

            IList<IList<string>> res = new List<IList<string>>();
            foreach (KeyValuePair<string, List<string>> item in map)
                res.Add(item.Value);

            return res;
        }
    }
}
