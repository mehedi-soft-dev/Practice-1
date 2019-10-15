using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountOperation
{
    public class Account
    {
        public string AccountNumber { set; get; }
        public string CustomerName { set; get; }
        public double Balance { private set; get; }

        public void Deposit(double ammount)
        {
            Balance += ammount;
        }
        public void Withdraw(double ammount)
        {
            Balance -= ammount;
        }
    }
}
