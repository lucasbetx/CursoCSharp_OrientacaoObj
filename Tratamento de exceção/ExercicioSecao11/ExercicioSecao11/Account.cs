using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExercicioSecao11.Exception;
using System.Globalization;

namespace ExercicioSecao11
{
    class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }

        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit(double amount)
        {

        }

        public void Withdraw (double amount)
        {
            double withdrawLimit = WithdrawLimit;

            if (withdrawLimit < amount)
            {
                throw new DomainException("Withdraw error: The amount exceeds withdraw limit");
            }

            double balance = Balance;

            if (withdrawLimit > balance)
            {
                throw new DomainException("Withdraw error: Not enough balance");
            }


            double result = balance - amount;

            Console.WriteLine("Enter amount for withdraw: " + result.ToString("F2", CultureInfo.InvariantCulture));
        }


    }
}
