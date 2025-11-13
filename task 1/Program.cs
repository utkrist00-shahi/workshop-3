using System.Numerics;

namespace Task_1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Operator.Add(20, 5);
            Operator.Subtract(10, 5);
            Operator.Multiply(30, 5);
            Operator.Divide(10, 5);
            Operator.OddEvenFinder(9);
            Operator.OddEvenFinder(7);

        }


    }
}