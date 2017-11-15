using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");

            string x = "Hello World";
            bool result = x.Equals("Good Bye");

            string root = "roar";
            string root2 = "roar";
            bool result = root.Equals(root2, StringComparison.Ordinal);

            string[] values = { "three", "123", Int32.MaxValue.ToString() };

            string nullString = null;
            string[] strings = { "Sheep".ToString(), nullString };

            vehicles(1) = "honda";
            vehicles(2) = "ford";
            Array.Sort(vehicles);
        }
    }
}
