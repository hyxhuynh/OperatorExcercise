using System;

namespace OperatorExcercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 8;
            int y = 7;

            int addition = x + y;
            Console.WriteLine($"{x}+{y} is {addition}.");

            int substraction = x - y;
            Console.WriteLine($"{x}-{y} is {substraction}.");

            int multiplication = x * y;
            Console.WriteLine($"{x}*{y} is {multiplication}.");

            int a = 17;
            int b = 4;
            int quotient = a / b;
            int remainder = a % b;
            Console.WriteLine($"{a}/{b} is {quotient} remainder {remainder}.");
        }
    }
}
