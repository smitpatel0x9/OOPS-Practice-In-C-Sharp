public interface ICar
{
    void Start();
    void Stop();
}
public class Innova : ICar
{
    public void Start()
    {
        Console.WriteLine("Innova Start");
    }
    public void Stop()
    {
        Console.WriteLine("Innova Stop");
    }
}
public class BMW : ICar
{
    public void Start()
    {
        Console.WriteLine("BMW Start");
    }
    public void Stop()
    {
        Console.WriteLine("BMW Stop");
    }
}
public class Program
{
    public static void Main()
    {
        Innova c1 = new();
        c1.Start();
        c1.Stop();

        BMW c2 = new();
        c2.Start();
        c2.Stop();
    }
}