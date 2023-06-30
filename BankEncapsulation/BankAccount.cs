using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulation
{
    public class BankAccount
    {
        private double _balance = 0; 

        public void Deposit(double deposit)
        {
            _balance += deposit;
            Console.WriteLine($"Your current balance is ${_balance}");
        }
        public void GetBalance() 
        {
            Console.WriteLine($"Your current balance is ${_balance}");            
        }
        public void Withdraw(double withdraw)
        {
            _balance -= withdraw;
            Console.WriteLine($"Your current balance is ${_balance}");
        }
    }
}
