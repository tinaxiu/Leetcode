using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class _8
    {
        public void runCode()
        {
            string str = "42";
            int n =  MyAtoi(str);
        }
        public int MyAtoi(string str)
        {
            Int64 res = 0;
            int i = 0, m = 1;
            if (str.Length == 0 || str == "") return 0;
            while(str[i] == ' ')
            {
                if (++i >= str.Length) return 0;
            }
            if (str[i] == '-')
            {
                m = -1;
                i++;
            }
            else if (str[i] == '+')
            {
                m = 1;
                i++;
            }


            for (; i < str.Length; i++)
            {
                if (str[i] - '0' >= 0 && str[i] - '0' < 10)
                {
                    res = res * 10 + (str[i] - '0');
                    if (res >= Int32.MaxValue && m ==1)
                    {
                        res = Int32.MaxValue;
                        break;
                    }
                    else if (m ==-1 && m*res <= Int32.MinValue )
                    {
                        res = Int32.MinValue;
                        m = 1;
                        break;
                    }
                }
                else
                {
                    break;
                }
            }

            int t = Convert.ToInt32(res);
            return t* m;
        }
    }
}
