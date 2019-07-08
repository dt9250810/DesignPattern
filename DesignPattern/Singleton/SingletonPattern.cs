using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Singleton
{
    class SingletonPattern
    {
        public class Singleton {
            private static Singleton instance = new Singleton();
            private Singleton() { }

            public static Singleton getInstance()
            {
                return instance;
            }

            public void getMsg()
            {
                Console.WriteLine("I'm the only one instance.");
            }
        }
        public class Demo
        {
            public static void main()
            {
                // Because its property is private, so we can't construct directly
                // Singleton singleton = new Singleton();
                Singleton singleton = Singleton.getInstance();
                singleton.getMsg();
            }
        }
    }
}
