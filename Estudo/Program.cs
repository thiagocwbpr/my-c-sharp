using System;
using System.Collections.Generic;

namespace Estudo
{
    class Program
    {
        static void Main(string[] args) {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;

            DateTime n1 = DateTime.Parse("2000-08-15 13:05:58");
            DateTime n2 = DateTime.Parse("2000-08-20T13:05:58Z");

            Console.WriteLine("n1: "+ n1);
            Console.WriteLine("n2: "+ n2);
            Console.WriteLine("");
      
        }
    }
}
