using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class _13
    {
        public void runCode()
        {
            RomanToInt("III");
        }
        public int RomanToInt(string s)
        {
            Dictionary<string, int> roma = new Dictionary<string, int>();

            roma.Add("M", 1000);
            roma.Add("D", 500);
            roma.Add("C", 100);
            roma.Add("L", 50);
            roma.Add("X", 10);
            roma.Add("V", 5);
            roma.Add("I", 1);
            roma.Add("IV", 4);
            roma.Add("IX", 9);
            roma.Add("XL", 40);
            roma.Add("XC", 90);
            roma.Add("CD", 400);
            roma.Add("CM", 900);

            int i = 0;
            int res = 0;

            while(i < s.Length)
            {
                
                if(roma.ContainsKey(s[i].ToString()))
                {
                    string str = "";
                    if (i+1 < s.Length)
                    {
                        str = s[i].ToString() + s[i + 1].ToString();
                        if (i + 1 >= 0 && roma.ContainsKey(str))
                        {                            
                            i = i + 2;
                        }
                        else
                        {
                            str = s[i].ToString();
                            i = i + 1;
                        }
                    }
                    else
                    {
                        str = s[i].ToString();
                        i = i + 1;                                              
                    }
                    res += roma[str];



                }

            }

            return res;
        }


    }
}
