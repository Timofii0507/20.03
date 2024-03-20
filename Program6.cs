using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20._03
{
    class Program
    {
        static void Main()
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.CursorVisible = false;
            Action displayCurrentTime = () => Console.WriteLine(DateTime.Now.ToLongTimeString());
            Action displayCurrentDate = () => Console.WriteLine(DateTime.Now.ToShortDateString());
            Action displayCurrentDayOfWeek = () => Console.WriteLine(DateTime.Now.DayOfWeek);

            Func<double, double, double, double> calculateTriangleArea = (a, b, c) =>
            {
                double s = (a + b + c) / 2;
                return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
            };

            Func<double, double, double> calculateRectangleArea = (width, height) => width * height;

            displayCurrentTime();
            displayCurrentDate();
            displayCurrentDayOfWeek();

            double triangleArea = calculateTriangleArea(3, 4, 5);
            Console.WriteLine($"Площа трикутника: {triangleArea}");

            double rectangleArea = calculateRectangleArea(10, 20);
            Console.WriteLine($"Площа прямокутника: {rectangleArea}");
        }
    }
}
