namespace MethodHidingDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Child obj1 = new Child();
            obj1.Show();
            obj1.Display();
        }
    }
    public class Parent
    {
        public virtual void Show() // Virtual method
        {
            Console.WriteLine("Parent class Show method");
        }
        public void Display() // non-virtual method
        {
            Console.WriteLine("Parent class Display method");
        }
    }
    public class Child : Parent
    {
        public override void Show() // Method Overriding - Show() overridden by child class
        {
            Console.WriteLine("Child class Show method");
        }
        public new void Display() // Method Hiding - Display() hidden by child class
        {
            Console.WriteLine("Child class Display method");
        }
    }
}
