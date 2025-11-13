using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    public class Operator
    {


        public static void Add(int a, int b)
        {
            Console.WriteLine($"Sum of two numbers: {a + b}");
        }

        public static void Subtract(int a, int b)
        {
            Console.WriteLine($"Difference of two numbers: {a - b}");
        }

        public static void Multiply(int a, int b)
        {
            Console.WriteLine($"Product of two numbers: {a * b}");
        }

        public static void Divide(int a, int b)
        {
            Console.WriteLine($"The result of division of two numbers: {a / b}");
        }

        public static void OddEvenFinder(int number)
        {
            string value = (number % 2 == 0) ? $"{number} is Even Number" : $"{number} is Odd Number";
            Console.WriteLine($"{value}");
        }
    }
}