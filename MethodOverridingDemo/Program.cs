namespace MethodOverridingDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1 obj1 = new();
            obj1.Show();

            Class2 obj2 = new();
            obj2.Show();
        }
    }
    public class Class1
    {
        public virtual void Show()
        {
            Console.WriteLine("Method of class 1");
        }
    }
    public class Class2 : Class1
    {
        public override void Show()
        {
            Console.WriteLine("Method of class 2");
        }
    }
}
