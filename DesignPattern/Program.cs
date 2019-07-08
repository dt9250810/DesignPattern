using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isOpen = true;
            Console.WriteLine("Console Design Pattern in C# by Bruce\r");

            while (isOpen)
            {
                Console.Write("> ");
                string option = Console.ReadLine();
                switch (option)
                {
                    case "a":
                        Console.WriteLine("a");
                        break;
                    case "s":
                        Console.WriteLine("a");
                        break;
                    case "m":
                        Console.WriteLine("a");
                        break;
                    case "d":
                        Console.WriteLine("a");
                        break;
                    case "0":
                        isOpen = false;
                        break;
                }
            }
            Console.WriteLine("Bye~");
            Console.ReadKey();
        }
    }
}
