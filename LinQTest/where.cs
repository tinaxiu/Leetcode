using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace LinQTest
{
    class where
    {
        static void runCode()
        {
            string[] words = { "humpty", "dumpty", "set", "on", "a", "wall" };

            IEnumerable<string> query = from word in words
                                        where word.Length == 3
                                        select word;

        }

    }
}
