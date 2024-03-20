using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20._03
{
    class Program
    {
        public delegate bool NumberPredicate(int number);

        static void Main()
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.CursorVisible = false;
            NumberPredicate isEven = number => number % 2 == 0;
            NumberPredicate isOdd = number => number % 2 != 0;
            NumberPredicate isPrime = number =>
            {
                if (number <= 1) return false;
                for (int i = 2; i * i <= number; i++)
                {
                    if (number % i == 0) return false;
                }
                return true;
            };
            NumberPredicate isFibonacci = number =>
            {
                int a = 0;
                int b = 1;
                while (a < number)
                {
                    int temp = a;
                    a = b;
                    b = temp + b;
                }
                return a == number || number == 0;
            };

            TestNumber(5, isEven, "парне");
            TestNumber(5, isOdd, "непарне");
            TestNumber(5, isPrime, "просте");
            TestNumber(5, isFibonacci, "число Фібоначчі");
        }

        static void TestNumber(int number, NumberPredicate predicate, string description)
        {
            Console.WriteLine($"Число {number} є {description}: {predicate(number)}");
        }
    }
}
