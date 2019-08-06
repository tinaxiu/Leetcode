using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class _273
    {
        public void runCode()
        {
            NumberToWords(1000000);
        }
        public string NumberToWords(int num)
        {
            if (num == 0) return "Zero";
            List<int> list = new List<int>(0);
            string res = "";
            Dictionary<int, string> eng = new Dictionary<int, string>() { { 0, "" }, { 1, "Thousand" }, { 2, "Million" }, { 3, "Billion" } };
            Dictionary<int, string> single = new Dictionary<int, string>()
            {
                {1,"One" },
                {2,"Two" },
                {3,"Three" },
                {4, "Four" },
                {5,"Five" },
                {6,"Six" },
                {7,"Seven"},
                {8,"Eight" },
                {9,"Nine" }
            };
            Dictionary<int, string> tens = new Dictionary<int, string>()
            {
                {2, "Twenty"},
                {3, "Thirty"},
                {4, "Forty"},
                {5, "Fifty"},
                {6, "Sixty"},
                {7, "Seventy"},
                {8, "Eighty"},
                {9, "Ninety"}
            };
            Dictionary<int, string> tens2 = new Dictionary<int, string>()
            {
                {10,"Ten" },
                {11,"Eleven" },
                {12, "Twelve"},
                {13, "Thirteen"},
                {14, "Fourteen"},
                {15, "Fifteen"},
                {16, "Sixteen"},
                {17, "Seventeen"},
                {18, "Eighteen"},
                {19, "Nineteen"}
            };
            while (num > 0 )
            {
                list.Add (num % 1000);
                num /= 1000;
            }

            for(int i =list.Count-1; i >= 0; i--)
            {
                int subNum = list[i];
                if (subNum == 0)
                    continue;
                if(subNum >= 100)
                {
                    res += " " + single[subNum / 100] + " Hundred";
                    subNum = subNum % 100;
                }
                if (subNum >= 20)
                {
                    res += " " + tens[subNum / 10];
                    subNum = subNum % 10;

                }
                if (subNum > 0 && subNum < 10)
                {
                    res += " " + single[subNum];
                }
                if (subNum >= 10 && subNum < 20)
                {
                    res += " " + tens2[subNum];
                    subNum = subNum % 10;
                }
                if(i != 0)
                    res += " " + eng[i];
            }
            return res.Substring(1,res.Length-1);
        }
    }
}
