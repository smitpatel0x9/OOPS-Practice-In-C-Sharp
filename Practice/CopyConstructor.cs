using System.ComponentModel.DataAnnotations;

public class CopyConstructor
{
    public static void Main()
    {
        Test check1 = new(3);
        check1.Display();
        Test check2 = new(check1);
        check2.Display();
    }
}

public class Test
{
    int x;
    public Test(int i)
    {
        x = i;
    }
    public Test(Test obj)
    {
        x = obj.x;
    }
    public void Display()
    {
        Console.WriteLine(x);
    }
}