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
                    case "1": // Factory Method
                        FactoryMethod.FactoryMethod.Demo.main();
                        break;
                    case "2":
                        Console.WriteLine("a");
                        break;
                    case "3":
                        Console.WriteLine("a");
                        break;
                    case "4":
                        Console.WriteLine("a");
                        break;
                    case "5":
                        Console.WriteLine("a");
                        break;
                    case "6":
                        Console.WriteLine("a");
                        break;
                    case "7":
                        Console.WriteLine("a");
                        break;
                    case "8":
                        Console.WriteLine("a");
                        break;
                    case "9":
                        Console.WriteLine("a");
                        break;
                    case "10":
                        Console.WriteLine("a");
                        break;
                    case "0":
                        isOpen = false;
                        break;
                }
                Console.WriteLine("------------------------------------------------");
            }
            Console.WriteLine("Bye~");
            Console.ReadKey();
        }
    }
}
