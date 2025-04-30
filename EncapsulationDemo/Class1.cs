using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationDemo
{
    public class Bank
    {
        public long _accountNumber;
        public string _name;
        private int _balance;
        public int GetBalance() => _balance;

        public void SetBalance(int balance)
        {
            if (balance < 0) throw new ArgumentException("Balance cannot be negative");
            _balance = balance;
        }

        public void WithdrawAmount() { }

        public void Deposit() { }
    }
}
