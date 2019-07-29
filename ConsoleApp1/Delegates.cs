using System;
using System.Collections.Generic;
using System.Text;



namespace ConsoleApp1
{
    delegate int NumberChanger(int n);
    class Delegates
    {
        class delegates
        {
            static int num = 10;
            public int add(int n)
            {
                num += n;
                return num;
            }

            public int multi(int n)
            {
                num *= n;
                return num;
            }

            public int getNum()
            {
                return num;
            }


        }

        public void runCode()
        {
            delegates dl = new delegates();
            
            NumberChanger n1 = new NumberChanger(dl.add);
            NumberChanger n2 = new NumberChanger(dl.multi);

            //n1(25);
            //n2(30);

            //Multicasting of a Delegate
            NumberChanger n;
            n = n1;
            n += n2;

            n(5);

            Console.WriteLine(dl.getNum());
        }
    }
}
