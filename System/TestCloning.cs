using System;
using System.Collections.Generic;
using System.Text;

namespace System
{
    class TestCloning
    {

        private static object Copy(ICloneable clone)
        {
            return clone.Clone();
        }
        static void Main(string[] args)
        {

            /// Case 1 Square
            var case1 = new Square(2);
            Console.WriteLine($"Original's - ");
            Console.WriteLine($"Side:{case1.Side} Perimeter: {case1.Perimeter} Area: {case1.Area}");

            Square copy1 = (Square)case1.Clone();

            Console.WriteLine($"Copy's - ");
            Console.WriteLine($"Side:{copy1.Side} Perimeter: {copy1.Perimeter} Area: {copy1.Area}");


            case1.Side = 3;
            Console.WriteLine($"### Modified ### ");
            Console.WriteLine($"Original's - ");
            Console.WriteLine($"Side:{case1.Side} Perimeter: {case1.Perimeter} Area: {case1.Area}");

            Console.WriteLine($"Copy's - ");
            Console.WriteLine($"Side:{copy1.Side} Perimeter: {copy1.Perimeter} Area: {copy1.Area}");

            ///Case 2 - Circle

            var case2 = new Circle(20);
            Console.WriteLine($"Original's - ");
            Console.WriteLine($"Radius:{case2.Radius} Circumference: {case2.Circumference} Area: {case2.Area}");

            Circle copy2 = (Circle)case2.Clone();

            Console.WriteLine($"Copy's - ");
            Console.WriteLine($"Radius:{copy2.Radius} Circumference: {copy2.Circumference} Area: {copy2.Area}");

            case2.Radius = 3.14159;
            Console.WriteLine($"### Modified ### ");
            Console.WriteLine($"Original's - ");
            Console.WriteLine($"Radius:{case2.Radius} Circumference: {case2.Circumference} Area: {case2.Area}");
            Console.WriteLine($"Copy's - ");
            Console.WriteLine($"Radius:{copy2.Radius} Circumference: {copy2.Circumference} Area: {copy2.Area}");
        }


    }
}
