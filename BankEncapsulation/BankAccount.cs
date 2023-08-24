using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulation
{
    public class BankAccount
    {
        public BankAccount() 
        { 
        }
        private double balance = 0;

        //Define deposit method and store value in balance field
        public void Deposit(double amount)
        {
            balance += amount;
        }
        // define method GetBalance to return amount stored
        public string GetBalance()
        {
            return $"${balance}";
        }


    }
}
