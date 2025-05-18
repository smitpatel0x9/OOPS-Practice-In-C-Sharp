using InheritanceDemo;
namespace Inheritance;
public class B : A // class B inheriting from class A
{
    public B(ref int number) : base(ref number)
    {
        Console.WriteLine($"Class B constructor is called {number}");
    }
    public void Method3()
    {
        Console.WriteLine("Method 3");
    }
    public static void Main()
    {
        int temp = 10;
        B obj = new B(ref temp); // Pass by reference
        obj.Method1(); // Inherited Method1 from class A
        obj.Method2(); // Inherited Method2 from class A
        obj.Method3(); // Method of class B

        Object obj2 = new Object();
        Console.WriteLine($"{obj2.GetType()}");
        int temp2 = 50;
        A obj3 = new A(ref temp2);
        Console.WriteLine($"{obj3.GetType()}");
        Console.WriteLine($"{obj.GetType()}");

    }
}