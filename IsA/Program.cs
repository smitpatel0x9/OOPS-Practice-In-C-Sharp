using IsADemo;
public class Program
{
    public static void Main()
    {
        Cuboid c1 = new(3, 4, 5);
        Console.WriteLine($"Volume : {c1.Volume()}");
        Console.WriteLine($"Area : {c1.Area()}");
        Console.WriteLine($"Perimeter : {c1.Perimeter()}");
    }
}