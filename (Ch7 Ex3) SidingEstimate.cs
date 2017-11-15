using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the length: ");
            double length = double.Parse(Console.ReadLine());
            Console.Write("Enter the depth: ");
            double depth = double.Parse(Console.ReadLine());
            double total = CalcValues(length, depth);
            Console.WriteLine(total);
            Console.ReadLine();
        }

        private static double CalcValues(double Length, double Depth)
        {
            double total = (Length * Depth) * 5;
            return total;
        }
    }
}
