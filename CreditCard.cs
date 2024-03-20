using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20._03
{
    public class PinChangedEventArgs : EventArgs
    {
        public string OldPin { get; }
        public string NewPin { get; }

        public PinChangedEventArgs(string oldPin, string newPin)
        {
            OldPin = oldPin;
            NewPin = newPin;
        }
    }

    public class CreditCard
    {
        public string CardNumber { get; }
        public string CardHolderName { get; }
        public DateTime ExpiryDate { get; }
        private string _pin;
        public double CreditLimit { get; }
        private double _balance;

        public event EventHandler<PinChangedEventArgs> PinChanged;

        public CreditCard(string cardNumber, string cardHolderName, DateTime expiryDate, string pin, double creditLimit)
        {
            CardNumber = cardNumber;
            CardHolderName = cardHolderName;
            ExpiryDate = expiryDate;
            _pin = pin;
            CreditLimit = creditLimit;
        }

        public void TopUp(double amount)
        {
            _balance += amount;
        }

        public void Spend(double amount)
        {
            if (_balance + amount > CreditLimit)
            {
                Console.WriteLine("Ви перевищили кредитний ліміт.");
                return;
            }

            _balance -= amount;
        }

        public void StartUsingCredit()
        {
            Console.WriteLine("Початок використання кредитних коштів.");
        }

        public bool IsLimitReached(double amount)
        {
            return _balance + amount > CreditLimit;
        }

        public void ChangePin(string newPin)
        {
            string oldPin = _pin;
            _pin = newPin;
            OnPinChanged(oldPin, newPin);
        }

        protected virtual void OnPinChanged(string oldPin, string newPin)
        {
            PinChanged?.Invoke(this, new PinChangedEventArgs(oldPin, newPin));
        }
    }
}