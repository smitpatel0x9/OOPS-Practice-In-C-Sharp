namespace DelegateDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator obj1 = new();
            Operation op; // delegate instance
            //Console.WriteLine(obj1.Compute(2, 3, op)); op is not assigned yet
            op = obj1.Add;
            Console.WriteLine(obj1.Compute(1, 2,op));
            op = obj1.Sub;
            Console.WriteLine(obj1.Compute(2, 1, op));
        }
    }
    public delegate int Operation(int num1, int num2); // delegate

    // allows you to dynamically switch between Add and Sub methods at runtime. If you used normal
    // method calls, you would need to write separate calls for each method, reducing flexibility.
    public class Calculator
    {
        public int Add(int num1, int num2) => num1 + num2;
        public int Sub(int num1, int num2) => num1 - num2;

        public int Compute(int num1, int num2, Operation op) => op(num1, num2);
        // passing delegate as parameter
    }
}
