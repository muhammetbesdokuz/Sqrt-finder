using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace marh2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double val, result;
            System.Console.Write("enter a number:");
            val = double.Parse(System.Console.ReadLine());

            result = System.Math.Sqrt(val);

            System.Console.WriteLine("square root of the number {0} is {1}", val, result);
        }
    }
}
