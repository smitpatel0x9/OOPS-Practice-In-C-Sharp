namespace MultipleInheritanceWithInterface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Interface1 obj1 = new Class1();
            obj1.Test();
            obj1.Show();

            Interface2 obj2 = new Class1();
            obj2.Test();
            obj2.Show();

            Class1 obj3 = new();
            obj3.Test();
            ((Interface1)obj3).Show();
            ((Interface2)obj3).Show();
        }
    }
    interface Interface1
    {
        void Test();
        void Show();
    }
    interface Interface2
    {
        void Test();
        void Show();
    }
    public class Class1 : Interface1,Interface2 // Multiple Inheritance
    {
        public void Test() // Test method is implemented only once
        {
            Console.WriteLine($"Test from {this.GetType()}");
        }
        void Interface1.Show()
        {
            Console.WriteLine($"Show from {this.GetType()}");
        }
        void Interface2.Show()
        {
            Console.WriteLine($"Show from {this.GetType()}");
        }
    }
}
