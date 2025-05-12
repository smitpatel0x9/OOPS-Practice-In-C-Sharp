namespace OperatorOverloadingDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Complex c1 = new(3, 5);
            c1.Display();
            Complex c2 = new(2, 3);
            c2.Display();
            Complex obj = c1 + c2;
            obj.Display();
        }
    }
    public class Complex
    {
        private int _real;
        private int _imaginary;
        public Complex(int real = 0, int imaginary = 0)
        {
            _real = real;
            _imaginary = imaginary;
        }
        public static Complex operator +(Complex c1,Complex c2)
        {
            Complex temp = new();
            temp._real = c1._real + c2._real;
            temp._imaginary = c1._imaginary + c2._imaginary;
            return temp;
        }
        public void Display()
        {
            Console.WriteLine($"{_real} + {_imaginary}i");
        }
    }
}
