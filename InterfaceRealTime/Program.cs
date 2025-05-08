namespace InterfaceRealTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IBankAccount account1 = new SavingsAccount();
            account1.DepositAmount(1000);
            account1.WithdrawAmount(500);
            account1.DepositAmount(-50);
            account1.WithdrawAmount(1000);
            account1.DepositAmount(10000);
            account1.WithdrawAmount(9700);
            account1.WithdrawAmount(3000);
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
        private decimal _perDayWithdrawLimit = 10000;
        private decimal _todayWithdraw;
        public bool DepositAmount(decimal amount)
        {
            if (amount < 0)
            {
                Console.WriteLine("Amount should be greater than zero");
                return false;
            }
            _balance += amount;
            Console.WriteLine($"You have deposited {amount} in your savings account");
            Console.WriteLine($"Balance : {_balance}");
            return true;
        }
        public bool WithdrawAmount(decimal amount)
        {
            if (amount > _balance)
            {
                Console.WriteLine("Insufficient balance in your savings account");
                return false;
            }
            if(_todayWithdraw + amount > _perDayWithdrawLimit)
            {
                Console.WriteLine("Withdraw Limit reached for today");
                return false;
            }
            _balance -= amount;
            _todayWithdraw += amount;
            Console.WriteLine($"You have withdrawn {amount} from your savings account");
            Console.WriteLine($"Balance : {_balance}");
            return true;
        }
        public decimal CheckBalance() => _balance;
    }
    public class CurrentAccount : IBankAccount
    {
        private decimal _balance;
        public bool DepositAmount(decimal amount)
        {
            if (amount < 0)
            {
                Console.WriteLine("Amount should be greater than zero");
                return false;
            }
            _balance += amount;
            Console.WriteLine($"You have deposited {amount} in your current account");
            Console.WriteLine($"Balance : {_balance}");
            return true;
        }
        public bool WithdrawAmount(decimal amount)
        {
            if (amount > _balance)
            {
                Console.WriteLine("Insufficient balance in your current account");
                return false;
            }
            _balance -= amount;
            Console.WriteLine($"You have withdrawn {amount} from your savings account");
            Console.WriteLine($"Balance : {_balance}");
            return true;
        }
        public decimal CheckBalance() => _balance;
    }
}
