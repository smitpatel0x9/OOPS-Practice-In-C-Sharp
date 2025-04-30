using AbstractionDemo2;

public class Program
{
    public static void Main()
    {
        IBank sbi = BankFactory.GetBankObject("sbi");
        sbi.ValidateCard();
        sbi.WithdrawMoney();
        sbi.CheckBalance();
        sbi.BankTransfer();
        sbi.MiniStatement();

        IBank axix = BankFactory.GetBankObject("axix");
        axix.ValidateCard();
        axix.WithdrawMoney();
        axix.CheckBalance();
        axix.BankTransfer();
        axix.MiniStatement();
    }
}