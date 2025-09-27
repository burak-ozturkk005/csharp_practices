using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shape2
{
    public abstract class Shape
    {
        public abstract double CalculateArea();

    }
    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public override double CalculateArea()
        {
            return Width * Height;
        }
        public class Circle : Shape
        {
            public double Radius { get; set; }
            public override double CalculateArea()
            {
                return Math.PI * Radius * Radius;
            }
        }
        public class Triangle : Shape
        {
            public double Base { get; set; }
            public double Height { get; set; }
            public override double CalculateArea()
            {
                double Area = 0.5 * Base * Height;
                return Area;
            }
        }
        public class ShapeDrawer 
        {
            public static void DrawShapeArea(Shape shape)
            {
                double Area = shape.CalculateArea();
                Console.WriteLine($"The area is {Area}");
            }
        }
    }
}
