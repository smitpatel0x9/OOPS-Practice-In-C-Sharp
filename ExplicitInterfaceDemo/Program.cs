namespace ExplicitInterfaceDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1 obj1 = new();
            obj1.Add(5, 3);
            ((ITestInterface1)obj1).Sub(5, 3);

            ITestInterface1 obj2 = new Class1();
            obj2.Add(6, 8);
            obj2.Sub(8, 6);
        }
    }
    interface ITestInterface1
    {
        void Add(int num1, int num2);
        void Sub(int num1, int num2);
    }
    public class Class1 : ITestInterface1
    {
        public void Add(int num1,int num2)
        {
            Console.WriteLine($"Sum of {num1} and {num2} is {num1 + num2}");
        }
        void ITestInterface1.Sub(int num1, int num2)
        {
            Console.WriteLine($"Subtraction of {num1} and {num2} is {num1 - num2}");
        }
    }
}
