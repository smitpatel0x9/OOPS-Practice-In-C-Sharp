public abstract class AbsParent
{
    public void Add(int x,int y)
    {
        Console.WriteLine($"Addition of {x} and {y} is {x + y}");
    }
    public void Sub(int x,int y)
    {
        Console.WriteLine($"Subtraction of {x} and {y} is {x - y}");
    }
    public abstract void Mul(int x, int y);
    public abstract void Div(int x, int y);
}

public class AbsChild : AbsParent
{
    public override void Mul(int x,int y)
    {
        Console.WriteLine($"Multiplication of {x} and {y} is {x * y}");
    }
    public override void Div(int x, int y)
    {
        Console.WriteLine($"Division of {x} and {y} is {x / y}");
    }
    public void Something()
    {
        Console.WriteLine("Something");
    }
}

public class Program
{
    public static void Main()
    {
        AbsChild obj = new(); // Child class instance     
        AbsParent obj2 = obj; // Abstract class reference poiting to child class object
        obj2.Add(10, 5); // Abstract class reference can access abstract class non-abstract method
        obj2.Sub(10, 5);
        obj2.Mul(10, 5); // Abstract class reference can access abstract class abstract method
        obj2.Div(10, 5);
        //obj2.Something(); Abstract class reference cannot access pure child class methods
    }
}