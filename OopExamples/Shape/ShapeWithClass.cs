using System;
using System.Collections.Generic;
using System.Text;

namespace OopExamples.ShapeClass
{
    public abstract class Shape
    {
        public abstract double Area();
        public abstract void Draw();
        public virtual void Fill()
        { Console.WriteLine("Заливка фигуры цветом"); }
    }

    public class Circle: Shape 
    { 
        private double r;
        private readonly double pi = 3.14;

        public Circle(double r)
        {
            this.r = r;
        }
        public override double Area()
        {
            return pi * r * r;
        }
        public override void Draw()
        {
            Console.WriteLine($"Рисует круг радиусом {r}");
        }
    }

}
