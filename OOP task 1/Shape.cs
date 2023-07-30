using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_task_1
{
    abstract class Shape
    {
        public abstract double CalculateArea();
    }

    class Circle : Shape
    {
        public double radius;
        
        public override double CalculateArea()
        {
            return Math.PI * radius * radius;
        }

        public Circle (double Radius)
        {
            this.radius = Radius;
        }
    }

    class Rectangle : Shape
    {
        public double width;
        public double height;

        public override double CalculateArea()
        {
            return width * height;
        }

        public Rectangle (double width, double height)
        {
            this.width = width;
            this.height = height;
        }
    }
}
