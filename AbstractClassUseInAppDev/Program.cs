using AbstractClassInApplicationDevelopment;
namespace AbstractClassUseInAppDev
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Rectangle obj1 = new(3, 4);
            Console.WriteLine($"Area of Rectangle : {obj1.Area()}");

            Circle obj2 = new(4);
            Console.WriteLine($"Area of Circle : {obj2.Area()}");

            Triangle obj3 = new(5, 6);
            Console.WriteLine($"Area of Triangle : {obj3.Area()}");

            Cone obj4 = new(3, 4);
            Console.WriteLine($"Area of Cone : {obj4.Area()}");
        }
    }
}
