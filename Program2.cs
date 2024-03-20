using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20._03
{
    class Program2
    {
        public delegate int ArithmeticOperation(int a, int b);

        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.CursorVisible = false;
            ArithmeticOperation add = (a, b) => a + b;
            ArithmeticOperation subtract = (a, b) => a - b;
            ArithmeticOperation multiply = (a, b) => a * b;

            Console.WriteLine($"Додавання: {PerformOperation(add, 5, 3)}");
            Console.WriteLine($"Віднімання: {PerformOperation(subtract, 5, 3)}");
            Console.WriteLine($"Множення: {PerformOperation(multiply, 5, 3)}");
        }

        static int PerformOperation(ArithmeticOperation operation, int a, int b)
        {
            return operation(a, b);
        }
    }

}