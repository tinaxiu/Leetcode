using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQTest
{
    class Linq
    {
        static void runCode()
        {
            Linq l = new Linq();
            l.Qselect();
            
        }
        public void Qselect()
        {
            List<string> words = new List<string> { "abc", "def", "ghi", "jkl" };
            List<string> phrases = new List<string>() { "an apple a day", "the quick brown fox" };
            
            //Select
            var query = from w in words
                        select w.Substring(0, 1);

            foreach (string s in query)
            {
                Console.Write(s+ ", ");
            }

            Console.WriteLine();
            Console.ReadLine();
            //SelectMainy
            var query2 = from p in phrases
                         from w in p.Split(' ')
                         select w;
            foreach(string s in query2)
            {
                Console.Write(s + ", ");
            }


        }
    }
}

