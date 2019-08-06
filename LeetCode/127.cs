using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class _127
    {
        public void runCode()
        {
            string beginWord = "a";
            string endWord = "c";
            IList<string> wordList = new List<string>() { "a", "b", "c"};
            LadderLength(beginWord, endWord, wordList);
        }
        public int LadderLength(string beginWord, string endWord, IList<string> wordList)
        {
            int l = beginWord.Length;
            Dictionary<string, List<string>> dic = new Dictionary<string, List<string>>();
            foreach(string word in wordList)
            {
                for (int i = 0; i < l; i++)
                {
                    string newWord = word.Substring(0, i) + '*' + word.Substring(i + 1, l);
                    List<string> transform = new List<string>() { newWord };
                    transform.Add(word);
                    dic.Add(newWord, transform);

                }
            }

            Queue<KeyValuePair<string, int>> Q = new Queue<KeyValuePair<string, int>>();

            KeyValuePair<string, int> p = new KeyValuePair<string, int>(beginWord, 1);
            Q.Enqueue(p);

            Dictionary<string, bool> visited = new Dictionary<string, bool>();
            visited.Add(beginWord, true);

            while(Q.Count>0)
            {
                p = Q.Dequeue();
                string word = p.Key;
                int level = p.Value;
                for(int i =0; i<l; i++)
                {
                    string newWord = word.Substring(0, i) + '*' + word.Substring(i + 1, l);
                    foreach(string adjacentWord in dic.Keys)
                    {
                        if (adjacentWord == endWord)
                            return level + 1;
                        if(!visited.ContainsKey(adjacentWord))
                        {
                            visited.Add(adjacentWord, true);
                            Q.Enqueue(new KeyValuePair<string, int>(adjacentWord, level + 1));
                        }
                    }
                    
                }
            }
            return 0;
        }

        
    }
}
