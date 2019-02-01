using System;
using System.Collections.Generic;
using System.Text;

namespace System
{
    class Circle : ICloneable
    {
        private double _radius;

        //inline setting of variable and updating it, if different
        public double Radius { get { return _radius; } set { if (value == _radius) return; else { _radius = value; } } }
        public double Circumference { get { return (Radius * 2) * Math.PI; } }
        public double Area { get { return (Radius * Radius) * Math.PI; } }

        //constructor
        public Circle (double radius)
        {
            Radius = radius;
        }

        //modifying the implimented interface's function
        public object Clone()
        {
            var NewCircle = new Circle(this.Radius);
            return NewCircle;
        }
    }
}
