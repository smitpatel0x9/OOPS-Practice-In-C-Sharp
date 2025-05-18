public class Program
{
    public static void Main()
    {
        //Child c1 = new Child(); because of private constructor
        Child c2 = new Child(20); // beacuse of public parameterized constructor
    }
}

public class Parent
{
    private Parent()
    {
        Console.WriteLine("Parent Class Private Constructor");
    }
    public Parent(int num)
    {
        Console.WriteLine("Parent Class Public Constructor");
    }
}
//public class Child : Parent
//{
//    public Child() Parent constrcutor is inaccessible because it's private
//    {
//        Console.WriteLine("Child Class Constructor");
//    }
//}
public class Child : Parent
{
    public Child(int num) : base(num)
    {
        Console.WriteLine(num);
    }
}