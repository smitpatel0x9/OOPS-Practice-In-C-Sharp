using InheritanceDemo;
namespace Inheritance;
public class B : A // class B inheriting from class A
{
    public B(int number) : base(number)
    {
        Console.WriteLine($"Class B constructor is called {number}");
    }
    public void Method3()
    {
        Console.WriteLine("Method 3");
    }
    public static void Main()
    {
        B obj = new B(10); // Pass by value
        obj.Method1(); // Inherited Method1 from class A
        obj.Method2(); // Inherited Method2 from class A
        obj.Method3(); // Method of class B

        Object obj2 = new Object();
        Console.WriteLine($"{obj2.GetType()}");
        A obj3 = new A(50);
        Console.WriteLine($"{obj3.GetType()}");
        Console.WriteLine($"{obj.GetType()}");

    }
}