using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionDemo2
{
    public interface IBank
    {
        void ValidateCard();
        void WithdrawMoney();
        void CheckBalance();
        void BankTransfer();
        void MiniStatement();
    }
    public class BankFactory
    {
        public static IBank GetBankObject(string bankType)
        {
            if (bankType is "sbi") return new SBI();
            else if (bankType is "axix") return new AXIX();
            else return null;
        }
    }
    public class SBI : IBank
    {
        public void BankTransfer()
        {
            Console.WriteLine("SBI Bank BankTransfer");
        }
        public void CheckBalance()
        {
            Console.WriteLine("SBI Bank Check Balanace");
        }
        public void MiniStatement()
        {
            Console.WriteLine("SBI Bank Mini Statement");
        }
        public void ValidateCard()
        {
            Console.WriteLine("SBI Bank Validate Card");
        }
        public void WithdrawMoney()
        {
            Console.WriteLine("SBI Bank Withdraw Money");
        }
    }
    public class AXIX : IBank
    {
        public void BankTransfer()
        {
            Console.WriteLine("AXIX Bank BankTransfer");
        }
        public void CheckBalance()
        {
            Console.WriteLine("AXIX Bank Check Balanace");
        }
        public void MiniStatement()
        {
            Console.WriteLine("AXIX Bank Mini Statement");
        }
        public void ValidateCard()
        {
            Console.WriteLine("AXIX Bank Validate Card");
        }
        public void WithdrawMoney()
        {
            Console.WriteLine("AXIX Bank Withdraw Money");
        }
    }
}

