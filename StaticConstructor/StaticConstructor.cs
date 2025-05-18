using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class StaticConstructor
    {
        public int i;
        public static int j;
        static StaticConstructor()
        {
            Console.WriteLine("Static Constructor execution");
            //i = 5; Error : Only static members can be assigned by static constructors
            j = 10;
        }
        public StaticConstructor()
        {
            Console.WriteLine("Non static constructor");
            i = 10; 
            j = 20; // I can assign static member using non-static constructor
        }
    }
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Main method execution");
            //Console.WriteLine(i); Error : Object reference is required for accessing non-static member
            Console.WriteLine(StaticConstructor.j); // Prints 10, static constructor executed
            StaticConstructor obj1 = new StaticConstructor(); // j = 20
            Console.WriteLine(obj1.i); // Prints 10
            Console.WriteLine(StaticConstructor.j); // Prints 20 because this time static constructor won't get executed (get's executed only once when the class first comes into play)
            StaticConstructor obj2 = new StaticConstructor(); // j = 20
            Console.WriteLine(StaticConstructor.j); // Prints 20
        }
    }
}
