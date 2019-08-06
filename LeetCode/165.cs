using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode
{
    class _165
    {
        public void runCode()
        {
            string version1 = "7.0.0";
            string version2 = "7.0";
            int res = CompareVersion(version1, version2);
        }
        public int CompareVersion(string version1, string version2)
        {
            if (version1 == version2) return 0;
            int i = 0 , j = 0;
            int v1, v2;
            string []sub1 = version1.Split('.');
            string []sub2 = version2.Split('.');

            while ( i < sub1.Length && j< sub2.Length)
            {
                

                int.TryParse(sub1[i].ToString(), out v1);
                int.TryParse(sub2[j].ToString(), out v2);


                if (v1 > v2)
                    return 1;
                else if (v1 < v2)
                    return -1;
                else
                {
                    i++;
                    j++;
                }
                                            
            }

            if(i == sub1.Length && j == sub2.Length)
            {
                return 0;
            }
            else if(i<sub1.Length)
            {
                while ( i < sub1.Length)
                {
                    int.TryParse(sub1[i].ToString(), out v1);
                    if (v1 != 0)
                        return 1;
                    i++;
                }
            }
            else if(j < sub2.Length)
            {
                while(j <sub2.Length)
                {
                    int.TryParse(sub2[j].ToString(), out v2);
                    if (v2 != 0)
                        return -1;
                    j++;
                }
            }
            return 0;
        }
    }
}
