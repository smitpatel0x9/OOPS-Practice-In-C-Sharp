using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    public class A
    {
        public A(ref int number) // Parameterized constructor
        {
            Console.WriteLine($"Class A constructor is called {number}");
            number += 20; // Incrementing in class A constructor
        }
        public void Method1()
        {
            Console.WriteLine("Method 1");
        }
        public void Method2()
        {
            Console.WriteLine("Method 2");
        }
    }
}
