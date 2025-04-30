using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class StaticConstructor
    {
        int i;
        static int j;
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
        public static void Main()
        {
            Console.WriteLine("Main method execution");
            //Console.WriteLine(i); Error : Object reference is required for accessing non-static member
            Console.WriteLine(j);
            StaticConstructor obj = new StaticConstructor();
            //Console.WriteLine(i); Error : Object reference is required for accessing non-static member
            Console.WriteLine(j);
        }
    }
}
