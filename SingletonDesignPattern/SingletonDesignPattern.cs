public sealed class SingletonDesignPattern
{
    private static SingletonDesignPattern _instance; // to hold the reference to the single created instance of the class
    private static int _counter;
    private static readonly object InstanceLock = new object(); // for locking
    private SingletonDesignPattern() // single parameterless private constructor
    {
        _counter++;
        Console.WriteLine("Private constructor executed");
    }

    public static SingletonDesignPattern GetInstance()
    {
        lock (InstanceLock)
        {
            if (_instance is null) _instance = new();
            return _instance;
        }
    }
    public void SomeMethod(string message)
    {
        Console.WriteLine($"Some method called : {message}");
        Console.WriteLine(_counter);
    }
}

public class Program
{
    public static void Main()
    {
        SingletonDesignPattern obj1 = SingletonDesignPattern.GetInstance();
        obj1.SomeMethod("From place 1");
        SingletonDesignPattern obj2 = SingletonDesignPattern.GetInstance();
        obj2.SomeMethod("From place 2");
        Console.WriteLine(obj1 == obj2);
        // How many ever instances we create it all points to the first object created 
        // i.e. obj1
    }
}