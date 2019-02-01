using System;
using System.Collections.Generic;
using System.Text;

namespace System
{
    class Square : ICloneable
    {
        private double _side;

        //inline setting of variable and updating it, if different
        public double Side { get { return _side;} set { if (value == _side) return; else { _side = value; } } } 
        public double Perimeter { get { return Side * 4; } }

        public double Area { get { return Side * Side; } }

        //constructor
        public Square (double side)
        {
            Side = side;
        }

        //modifying the implimented interface's function
        public object Clone()
        {
            var NewSquare = new Square(this.Side);            

            return NewSquare;
        }
    }
}
