namespace InterfaceRealTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
    interface IBankAccount
    {
        bool DepositAmount(decimal amount);
        bool WithdrawAmount(decimal amount);
        decimal CheckBalance();
    }
    public class SavingsAccount : IBankAccount
    {
        private decimal _balance;
        private decimal _perDayWithdrawLimit;
        private decimal _todayWithdraw;
        public bool DepositAmount(decimal amount)
        {
            if (amount < 0)
            {
                Console.WriteLine("Amount should be greater than zero");
                return false;
            }
            _balance += amount;
            Console.WriteLine($"You have deposited {amount}");
            Console.WriteLine($"Balance : {_balance}");
            return true;
        }
        public bool WithdrawAmount(decimal amount)
        {
            if (amount > _balance)
            {
                Console.WriteLine("Insufficient balance");
                return false;
            }
            if(_todayWithdraw + amount > _perDayWithdrawLimit)
            {
                Console.WriteLine("Withdraw Limit reached for today");
                return false;
            }
            _balance -= amount;
            Console.WriteLine($"You have withdrawn {amount}");
            Console.WriteLine($"Balance : {_balance}");
            return true;
        }
        public decimal 
    }
}
