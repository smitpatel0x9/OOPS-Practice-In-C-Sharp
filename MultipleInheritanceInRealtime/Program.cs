namespace MultipleInheritanceInRealtime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HPLaserJetPrinter obj1 = new HPLaserJetPrinter();
            obj1.Print("Print Services by HPLaserJetPrinter");
            obj1.Scan("Scan Services by HPLaserJetPrinter");
            obj1.Fax("Fax Services by HPLaserJetPrinter");
            obj1.PrintDuplex("Print Duplex Services by HPLaserJetPrinter");

            LiquidInkJetPrinter obj2 = new LiquidInkJetPrinter();
            obj2.Print("Print Services by LiquidInkJetPrinter");
            obj2.Scan("Scan Services by LiquidInkJetPrinter");
        }
    }
    interface IPrinterTasks
    {
        void Print(string PrintContent);
        void Scan(string ScanContent);
    }
    interface IFaxTasks
    {
        void Fax(string content);
    }
    interface IPrintDuplexTasks
    {
        void PrintDuplex(string content);
    }
    public class HPLaserJetPrinter : IPrinterTasks,IFaxTasks,IPrintDuplexTasks
    {
        public void Print(string PrintContent)
        {
            Console.WriteLine(PrintContent);
        }
        public void Scan(string ScanContent)
        {
            Console.WriteLine(ScanContent);
        }
        public void Fax(string FaxContent)
        {
            Console.WriteLine(FaxContent);
        }
        public void PrintDuplex(string PrintDuplexContent)
        {
            Console.WriteLine(PrintDuplexContent);
        }
    }
    public class LiquidInkJetPrinter : IPrinterTasks
    {
        public void Print(string PrintContent)
        {
            Console.WriteLine(PrintContent);
        }
        public void Scan(string ScanContent)
        {
            Console.WriteLine(ScanContent);
        }
    }
}
