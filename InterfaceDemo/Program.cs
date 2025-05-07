namespace InterfaceDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1 obj1 = new();
            obj1.Add(5, 8);
            obj1.Mul(4, 8);
            Class2 obj2 = new();
            obj2.Add(4, 6);
            obj2.Sub(8, 6);
            ITestInterface1 ref1 = new Class1(); // Reference of an interface pointing to Class1 instance
            ref1.Add(9, 8);
            //ref1.Mul - Since ref1 is an interface reference it can only call methods whose signature is
            // defined inside the interface
            // ref1 cannot call methods whose signatures are defined in the class and not in the interface
            ITestInterface2 ref2 = new Class2();
            ref2.Add(6, 15);
            ref2.Sub(7, 3);
        }
    }
    interface ITestInterface1
    {
        void Add(int num1, int num2); // by default public and abstract
    }
    interface ITestInterface2 : ITestInterface1 // ITestInterface2 inheriting from ITestInterface1
    {
        void Sub(int num1, int num2);
    }
    public class Class1 : ITestInterface1 // Class1 has to implement Add(int num1,int num2)
    {
        public void Add(int num1,int num2)
        {
            Console.WriteLine($"Sum of {num1} and {num2} is {num1 + num2}");
        }
        public void Mul(int num1,int num2)
        {
            Console.WriteLine($"Multiplication of {num1} and {num2} is {num1 * num2}");
        }
    }
    public class Class2 : ITestInterface2 // Class2 has to implement Add(int num1,int num2) and Sub(int num1,int num2)
    {
        public void Add(int num1, int num2)
        {
            Console.WriteLine($"Sum of {num1} and {num2} is {num1 + num2}");
        }
        public void Sub(int num1,int num2)
        {
            Console.WriteLine($"Difference of {num1} and {num2} is {num1 - num2}");
        }
    }
}
