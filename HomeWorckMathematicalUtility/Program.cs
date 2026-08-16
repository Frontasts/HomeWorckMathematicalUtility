using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorckMathematicalUtility
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Математическая Утилита ===");
            Console.WriteLine();

            Random random = new Random();
            double x = random.Next(0, 1000);
            double y = random.Next(0, 1000);

            double sum = MathUtility.Add(x, y);
            Console.WriteLine($"{x} + {y} = {sum}");

            double diff = MathUtility.Subtract(x, y);
            Console.WriteLine($"{x} - {y} = {diff}");

            double prod = MathUtility.Multiply(x, y);
            Console.WriteLine($"{x} * {y} = {prod}");

            double quot = MathUtility.Divide(x, y);
            Console.WriteLine($"{x} / {y} = {quot}");

            Console.WriteLine();

            double bad = MathUtility.Divide(x, 0);
            Console.WriteLine($"Результат деления на 0: {bad}");
        }
    }
}
