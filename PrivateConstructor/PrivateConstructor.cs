public class PrivateConstructor
{
    private PrivateConstructor()
    {
        Console.WriteLine("This is a private constrcutor");
    }
    public static void Main()
    {
        PrivateConstructor obj = new PrivateConstructor();
        Console.WriteLine("Main method");
    }
}
public class Test
{
    //PrivateConstructor obj2 = new PrivateConstructor(); Not possible as Constructor is private
}