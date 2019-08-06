using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class _12
    {
        public void runCode()
        {
            IntToRoman(4);
        }
        public string IntToRoman(int num)
        {
            if (num == 1) return "I";
            SortedList<int, string> roma = new SortedList<int, string>();

            roma.Add(1000, "M");
            roma.Add(500, "D");
            roma.Add(100, "C");
            roma.Add(50, "L");
            roma.Add(10, "X");
            roma.Add(5, "V");
            roma.Add(1, "I");
            roma.Add(4, "IV");
            roma.Add(9, "IX");
            roma.Add(40, "XL");
            roma.Add(90, "XC");
            roma.Add(400, "CD");
            roma.Add(900, "CM");

            List<int> number = new List<int> { 1, 4, 5, 9, 10, 40, 50, 90, 100, 400, 500, 900, 1000 };
            int b = 0;
            string res = "";
            int key = 0;
            while (num > 0 && key <= number.Count && key >= 0)
            {
                if (num >= 1000)
                {
                    key = number.Count - 1;
                    b = number[key];
                }
                else
                {
                    if (num >= number[key])
                    {
                        b = number[key];
                        key++;
                        continue;
                    }
                    else
                    {
                        key--;
                        b = number[key];
                    }
                }



                while (num >= b)
                {
                    res += roma[b];
                    num = num - b;
                }
            }

            return res;


        }
    }
}
