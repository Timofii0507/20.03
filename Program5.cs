using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20._03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.CursorVisible = false;
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 13, 21, 34 };

            ArrayProcessors.ArrayProcessor findEvens = NumberChecks.GetEvenNumbers;
            ArrayProcessors.ArrayProcessor findOdds = NumberChecks.GetOddNumbers;
            ArrayProcessors.ArrayProcessor findPrimes = NumberChecks.GetPrimeNumbers;
            ArrayProcessors.ArrayProcessor findFibonacci = NumberChecks.GetFibonacciNumbers;

            Console.WriteLine("Парні числа: " + string.Join(", ", findEvens(array)));
            Console.WriteLine("Непарні числа: " + string.Join(", ", findOdds(array)));
            Console.WriteLine("Прості числа: " + string.Join(", ", findPrimes(array)));
            Console.WriteLine("Числа Фібоначчі: " + string.Join(", ", findFibonacci(array)));
        }
    }
}
