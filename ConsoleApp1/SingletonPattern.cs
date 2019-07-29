using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    //
    //No Thread Safe Singleton
    //
    class SingletonPattern1
    {
        public sealed class Singleton
        {
            //Private Constructor.  
            private Singleton()
            {
            }
            private static Singleton instance = null;
            public static Singleton Instance
            {
                get
                {
                    if (instance == null)
                    {
                        instance = new Singleton();
                    }
                    return instance;
                }
            }
        }

     
    }

    class SinglePattern2
    {
        public sealed class Singleton
        {
            Singleton()
            {
            }
            private static readonly object padlock = new object();
            // the thread is locked on a shared object and 
            //checks whether an instance has been created or not.

            private static Singleton instance = null;
            public static Singleton Instance
            {
                get
                {
                    lock (padlock)
                    {
                        if (instance == null)
                        {
                            instance = new Singleton();
                        }
                        return instance;
                    }
                }
            }
        }
    }

}
