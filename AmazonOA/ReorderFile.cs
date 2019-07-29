using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace AmazonOA
{
    class ReorderFile
    {
        public void runCode()
        {
            string[] a1 = new string[4] {
                "zo4 4 7",
                "a100 act zoo",
                "a1 9 2 3 1",
                "g9 act car"
            };

            ReorderLogFiles(a1);

        }

        public string[] ReorderLogFiles(string[] logs)
        {

            BigInteger intLog;

            var digits = logs.Where(l => BigInteger.TryParse(l.Split(' ')[1], out intLog));

            var letter = logs.Except(digits).OrderBy(l => l.Substring(l.IndexOf(' '))).ThenBy(t => t.Substring(0, t.IndexOf(' ')));

            return letter.Concat(digits).ToArray();




        }
    }
}
