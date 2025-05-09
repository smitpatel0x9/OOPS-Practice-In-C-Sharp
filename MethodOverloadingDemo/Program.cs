using System.Runtime.CompilerServices;

namespace MethodOverloadingDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program obj = new();
            obj.Method();
            obj.Method(1);
            obj.Method("abc");
            obj.Method(1,"abc");
            obj.Method("abc",1);
        }
        public void Method()
        {
            Console.WriteLine("1st Method");
        }
        public void Method(int i)
        {
            Console.WriteLine("2nd Method");
        }
        public void Method(string s)
        {
            Console.WriteLine("3rd Method");
        }
        public void Method(int i, string s)
        {
            Console.WriteLine("4th Method");
        }
        public void Method(string s, int i)
        {
            Console.WriteLine("5th Method");
        }
    }
}
