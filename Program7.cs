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
            Console.WriteLine("Введіть номер картки:");
            string cardNumber = Console.ReadLine();

            Console.WriteLine("Введіть ПІБ власника:");
            string cardHolderName = Console.ReadLine();

            Console.WriteLine("Введіть термін дії карти (MM/yyyy):");
            DateTime expiryDate;
            while (!DateTime.TryParseExact(Console.ReadLine(), "MM/yyyy", null, System.Globalization.DateTimeStyles.None, out expiryDate))
            {
                Console.WriteLine("Некоректний формат. Будь ласка, введіть термін дії карти у форматі MM/yyyy:");
            }

            Console.WriteLine("Введіть PIN:");
            string pin = Console.ReadLine();

            Console.WriteLine("Введіть кредитний ліміт:");
            double creditLimit;
            while (!double.TryParse(Console.ReadLine(), out creditLimit) || creditLimit <= 0)
            {
                Console.WriteLine("Некоректне значення. Будь ласка, введіть кредитний ліміт (позитивне число):");
            }

            CreditCard creditCard = new CreditCard(cardNumber, cardHolderName, expiryDate, pin, creditLimit);

            creditCard.PinChanged += (sender, e) =>
            {
                Console.WriteLine($"PIN змінено з {e.OldPin} на {e.NewPin}");
            };

            Console.WriteLine("Введіть суму для поповнення рахунку:");
            double topUpAmount;
            while (!double.TryParse(Console.ReadLine(), out topUpAmount) || topUpAmount <= 0)
            {
                Console.WriteLine("Некоректне значення. Будь ласка, введіть суму для поповнення рахунку (позитивне число):");
            }
            creditCard.TopUp(topUpAmount);

            Console.WriteLine("Введіть суму для витрати з рахунку:");
            double spendAmount;
            while (!double.TryParse(Console.ReadLine(), out spendAmount) || spendAmount <= 0)
            {
                Console.WriteLine("Некоректне значення. Будь ласка, введіть суму для витрати з рахунку (позитивне число):");
            }
            creditCard.Spend(spendAmount);

            creditCard.StartUsingCredit();

            Console.WriteLine($"Досягнуто ліміту: {creditCard.IsLimitReached(4500)}");

            Console.WriteLine("Введіть новий PIN:");
            string newPin = Console.ReadLine();
            creditCard.ChangePin(newPin);

            Console.ReadLine();
        }
    }
}