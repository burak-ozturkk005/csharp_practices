using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopexercise
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
            double Area = Width * Height;
            return Area;
        }
    }
    public class Circle : Shape
    {
        public double Radius { get; set; }
        public override double CalculateArea()
        {
            double Area = Math.PI * Radius * Radius;
            return Area;
        }
    }
}
