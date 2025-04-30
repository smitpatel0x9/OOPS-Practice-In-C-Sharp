using AccessSpecifiersDemo;
using System.Numerics;

public class Program
{
    public static void Main()
    {

    }
}
public class AnotherAssemblyClass1 : Class1
{
    public void Display4()
    {
        // Console.WriteLine(_id1); Cannot access due to its protection level
        // You cannot access private member from derived class of different assembly

        Console.WriteLine(_id2); // Can access public members from derived class of different assembly

        Console.WriteLine(_id3); // Can access protected members from derived class of different assembly

        // Console.WriteLine(_id4); Compile-time error : _id4 is inaccessible due to its protection level
        // Cannot access internal members from derived class of different assembly

        Console.WriteLine(_id5); // Can access protected internal members from derived class of different assembly

        // Console.WriteLine(_id6); Compile-time error : _id6 is inaccessible due to its protection level
        // Cannot access private protected membrs from derived class of different assembly
    }
}
public class AnotherAssemblyClass2
{
    public void Display5()
    {
        Class1 obj2 = new Class1();

        // Console.WriteLine(obj2._id1); _id1 is inaccessible due to its protection level
        // You cannot access private member from a non-derived class of different assembly

        Console.WriteLine(obj2._id2); // Can access public members from non-derived class of different assembly

        // Console.WriteLine(obj2._id3);  Complie-time Error : _id3 is inaccessible due to its protection level
        // Cannot access protected members from non-derived class of different assembly

        // Console.WriteLine(obj2._id4); Compile-time error : _id4 is inaccessible due to its protection level
        // Cannot access internal members from non-derived class of different assembly

        // Console.WriteLine(obj2._id5); Compile - time error: _id5 is inaccessible due to its protection level
        // Cannot access protected internal members from non-derived class of different assembly

        // Console.WriteLine(obj2._id6); Compile - time error: _id5 is inaccessible due to its protection level
        // Cannot access private protected members from non-derived class of different assembly
    }
}