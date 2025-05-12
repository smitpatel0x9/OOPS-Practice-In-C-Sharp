namespace MethodOverridingDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1 obj1 = new Class1();
            obj1.Show();

            Class2 obj2 = new Class2();
            obj2.Show();

            Class1 obj3 = new Class2(); // obj3 is reference of type Class1, pointing to object of Class2
            obj3.Show();
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
