using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassInApplicationDevelopment
{
    public abstract class Shape
    {
        public double _height;
        public double _width;
        public double _radius;
        public const double _PI = 3.14f;
        public abstract double Area();
    }
    public class Rectangle : Shape
    {
        public Rectangle(int height,int width)
        {
            _height = height;
            _width = width;
        }
        public override double Area() => _height * _width;
    }
    public class Circle : Shape
    {
        public Circle(int radius)
        {
            _radius = radius;
        }
        public override double Area() => _PI * Math.Pow(_radius, 2);
    }
    public class Triangle : Shape
    {
        public Triangle(int width,int height)
        {
            _width = width;
            _height = height;
        }
        public override double Area() => 0.5 * _width * _height;
    }
    public class Cone : Shape
    {
        public Cone(int height,int radius)
        {
            _height = height;
            _radius = radius;
        }
        public override double Area() => (1 / 3.0) * _PI * Math.Pow(_radius, 2) * _height;
    }
}
