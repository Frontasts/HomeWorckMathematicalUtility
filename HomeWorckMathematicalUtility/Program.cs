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

            double firstNumber = random.Next(0, 1000);
            double secondNumber = random.Next(0, 1000);

            double sum = MathUtility.Add(firstNumber, secondNumber);
            Console.WriteLine($"{firstNumber} + {secondNumber} = {sum}");

            double difference = MathUtility.Subtract(firstNumber, secondNumber);
            Console.WriteLine($"{firstNumber} - {secondNumber} = {difference}");

            double product = MathUtility.Multiply(firstNumber, secondNumber);
            Console.WriteLine($"{firstNumber} * {secondNumber} = {product}");

            double quotient = MathUtility.Divide(firstNumber, secondNumber);
            Console.WriteLine($"{firstNumber} / {secondNumber} = {quotient}");

            Console.WriteLine();

            double badQuotient = MathUtility.Divide(firstNumber, 0);
            Console.WriteLine($"Результат деления на 0: {badQuotient}");
        }
    }
}
