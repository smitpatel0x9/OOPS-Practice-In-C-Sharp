using EncapsulationDemo;

public class Program
{
    public static void Main()
    {
        try
        {
            Bank b1 = new Bank();
            b1._accountNumber = 123456789;
            b1._name = "ABC";
            b1.SetBalance(-5000);
            Console.WriteLine(b1.GetBalance());
        }
        //b1.GetBalance();
        //b1.Deposit();
        catch(Exception Ex)
        {
            Console.WriteLine(Ex.Message);
        }
    }
}