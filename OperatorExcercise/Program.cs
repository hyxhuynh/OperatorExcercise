using System;

namespace OperatorExcercise
{
    class Program
    {
        // Method to calculate Area of a Circle
        public static double AreaOfCircle(double r)
        {
            double pi = Math.PI;
            return pi * r * r;
        }
        static void Main(string[] args)
        {   
            // Arithmetic Operators
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
            Console.WriteLine($"{a}/{b} is {quotient} remainder {remainder}.\n");

            // Calculate Area of Circle using user input
            Console.WriteLine("What is the radius of the circle?");
            double radius = double.Parse(Console.ReadLine());
            double areaResult = AreaOfCircle(radius);
            Console.WriteLine($"The area of a circle with radius {radius} is {areaResult}.\n");


            // Thought Excercise
            Console.WriteLine("What is the value of k in the following code?\n" +
                "> var i = 3;\n> var j = 4;\n> var k = ++i * j++;\n> Console.WriteLine(k); ");
            var answer = Console.ReadLine();
            
            var i = 3;
            var j = 4;
            var k = ++i * j++;
            Console.WriteLine($"The correct answer is {k}.");
        }
    }
}
