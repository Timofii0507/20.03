using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20._03
{
    public delegate void MessageDisplayDelegate(string message);

    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.CursorVisible = false;
            MessageDisplayDelegate displayDelegate = DisplayMessage;

            displayDelegate("Це текстове повідомлення, відображене через делегат.");

            displayDelegate += DisplayMessageUpperCase;
            displayDelegate += DisplayMessageLowerCase;

            displayDelegate("Тестуємо різні методи виклику.");
        }

        static void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }

        static void DisplayMessageUpperCase(string message)
        {
            Console.WriteLine(message.ToUpper());
        }

        static void DisplayMessageLowerCase(string message)
        {
            Console.WriteLine(message.ToLower());
        }
    }
}
