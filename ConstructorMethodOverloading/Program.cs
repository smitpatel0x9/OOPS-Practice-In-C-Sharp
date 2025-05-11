namespace ConstructorMethodOverloading
{
    internal class Program
    {
        int x,y,z;
        static void Main(string[] args)
        {
            Program obj1 = new(10);
            obj1.Display();
            Program obj2 = new(10, 20);
            obj2.Display();
            Program obj3 = new(10, 20, 30);
            obj3.Display();
        }
        public  Program(int x)
        {
            this.x = x;
        }
        public Program(int x,int y) : this(x)
        {
            this.y = y;
        }
        public Program(int x, int y, int z) : this(x, y)
        {
            this.z = z;
        }
        public void Display()
        {
            Console.WriteLine($"x : {x} y : {y} z : {z}");
        }
    }
}
