using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class find_common_characters
    {
        public IList<string> CommonChars(string[] A)
        {
            List<string> res = new List<string>();
            List<string> ls = new List<string>();

            foreach (char c in A[0])
            {
                ls.Add(c.ToString());
            }

            for(int i =1; i<A.Length; i++)
            {
                foreach(char c in A[i])
                {
                    if(ls.Contains(c.ToString()))
                    {
                        res.Add(c.ToString());
                        ls.Remove(c.ToString());
                    }
                    
                }
                ls.Clear();
                ls = new List<string>(res);
                res.Clear();
            }
            res = ls;
            return res;
            
            
         }


        
    }
}
