using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace IsADemo
{
    public class Rectangle
    {
        public double _length;
        public double _width;

        public double Area() => _length * _width;

        public double Perimeter() => 2 * (_length + _width);
    }

    public class Cuboid : Rectangle // Establishing Parent-Child Relationship
                                    // IsA Relationship : Cuboid IsA a Rectangle
    {
        double _height;
        public Cuboid(double length, double width, double height)
        {
            _length = length;
            _width = width;
            _height = height;
        }

        public double Volume() => Area() * _height;
    }
}