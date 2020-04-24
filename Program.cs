using System;

namespace CalculatorConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculator = new Calculator.BL.Calculator();
            Console.WriteLine(calculator.Calculate(10, 5, "/"));
        }
    }
}
