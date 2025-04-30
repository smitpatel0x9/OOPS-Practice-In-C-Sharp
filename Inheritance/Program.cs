using InheritanceDemo;

public class B : A // class B inheriting from class A
{
    public B()
    {
        Console.WriteLine("Class B constructor is called");
    }
    public void Method3()
    {
        Console.WriteLine("Method 3");
    }
    public static void Main()
    {
        B obj = new B();
        obj.Method1(); // Inherited Method1 from class A
        obj.Method2(); // Inherited Method2 from class A
        obj.Method3(); // Method of class B
    }
}