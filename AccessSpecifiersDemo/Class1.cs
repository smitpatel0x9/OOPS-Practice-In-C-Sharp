using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessSpecifiersDemo
{
    public class Class1
    {
        private int _id1;
        public int _id2;
        protected int _id3;
        internal int _id4;
        protected internal int _id5;
        private protected int _id6;
        public void Display1()
        {
            Console.WriteLine(_id1); // can access private members within the class
            Console.WriteLine(_id2); // can access public members within the class
            Console.WriteLine(_id3); // can access protected members within the class
            Console.WriteLine(_id4); // can access internal members within the class
            Console.WriteLine(_id5); // can access protected internal members within the class
            Console.WriteLine(_id6); // can access private protected members within the class
        }
    }
    public class Class2 : Class1
    {
        public void Display2()
        {
            // Console.WriteLine(_id1);  Compile-time Error : _id1 is inaccessible due to its protection level
            // cannot access private member from a derived class in the same assembly
            Console.WriteLine(_id2); // Can access public members from derived class of same assembly
            Console.WriteLine(_id3); // Can access protected members from derived class of same assembly
            Console.WriteLine(_id4); // Can access internal members from derived class of same assembly
            Console.WriteLine(_id5); // Can access protected internal members from derived class of same assembly
            Console.WriteLine(_id6); // Can access private protected members from derived class of same assembly
        }
    }
    public class Class3
    {
        public void Display3()
        {
            Class1 obj1 = new Class1();

            // Console.WriteLine(obj1._id1);  Complie-time Error : _id1 is inaccessible due to its protection level
            // cannot access private members from a non-derived class in the same assembly

            Console.WriteLine(obj1._id2); // Can access public members from non-derived class within same assembly

            // Console.WriteLine(obj1._id3)  Complie-time Error : _id3 is inaccessible due to its protection level
            // Cannot access protected members from non-derived class within same assembly

            Console.WriteLine(obj1._id4); // Can access internal members from non-derived class within same assembly

            Console.WriteLine(obj1._id5); // Can access protected internal members from non-derived class within same assembly

            // Console.WriteLine(obj1._id6)  Complie -time Error : _id6 is inaccessible due to its protection level
            // Cannot access private protected members from non-derived class within same assembly
        }
    }
}
