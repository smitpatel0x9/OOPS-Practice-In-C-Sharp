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
}

public class Program
{
    public static void Main()
    {
        AbsChild obj = new();
        obj.Add(10, 5);
        obj.Sub(10, 5);
        obj.Mul(10, 5);
        obj.Div(10, 5);
    }
}