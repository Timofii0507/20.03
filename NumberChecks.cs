using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20._03
{
    public class NumberChecks
    {
        public static IEnumerable<int> GetEvenNumbers(int[] array)
        {
            return array.Where(x => x % 2 == 0);
        }

        public static IEnumerable<int> GetOddNumbers(int[] array)
        {
            return array.Where(x => x % 2 != 0);
        }

        public static IEnumerable<int> GetPrimeNumbers(int[] array)
        {
            return array.Where(IsPrime);
        }

        private static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            var boundary = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 3; i <= boundary; i += 2)
            {
                if (number % i == 0) return false;
            }

            return true;
        }

        public static IEnumerable<int> GetFibonacciNumbers(int[] array)
        {
            return array.Where(IsFibonacci);
        }

        private static bool IsFibonacci(int number)
        {
            int a = 0;
            int b = 1;
            if (number == a || number == b) return true;
            int c = a + b;
            while (c <= number)
            {
                if (c == number) return true;
                a = b;
                b = c;
                c = a + b;
            }
            return false;
        }
    }
}
