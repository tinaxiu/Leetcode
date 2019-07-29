using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Log_Sorting_AMOA
    {
        public void runCode()
        {
            string[] a1 = new string[4] {
                "zo4 4 7",
                "a100 Act zoo",
                "a1 9 2 3 1",
                "g9 act car"
            };

            logSort(a1);

        }

        public string [] logSort( string [] logs)
        {
            List<string> letters = new List<string>();
            List<string> nums = new List<string>();
            int cnt = logs.Length - 1;
            foreach(string str in logs)
            {
                int index = str.IndexOf(' ');
                string body = str.Substring(index + 1);
                if(body[0] >= '0' && body[0]<='9')
                {
                    nums.Add(str);
                }
                else
                {
                    letters.Add(str);
                }
                letters.Sort();
                
            }

            string[] ans = new string[logs.Length];//letters.ToArray();
            
            letters.ToArray().CopyTo(ans, 0);
            nums.ToArray().CopyTo(ans, letters.Count);

            return ans;


        }
    }
}
