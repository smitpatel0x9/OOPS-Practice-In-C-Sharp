public class Program
{
    public static void Main()
    {
        Child c1 = new Child();
    }
}

public class Parent
{
    private Parent()
    {
        Console.WriteLine("Parent Class Private Constructor");
    }
}
public class Child : Parent
{
    public Child() // Parent constrcutor is inaccessible because it's private
    {
        Console.WriteLine("Child Class Constructor");
    }
}