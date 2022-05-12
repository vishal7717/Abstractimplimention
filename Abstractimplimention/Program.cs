using System;

namespace Abstractimplimention
{
    public abstract class Program
    {
        public double Width, Height, Radius;
        public const float Pi = 3.14f;
        public abstract double GetArea();
    }
    public class Rectangle:Program
    {   
        public Rectangle(double Width,double Height)
        {
            this.Width = Width;
            this.Height = Height;
        }
        public override double GetArea()
        {
            return Width * Height;
        }
    }
    public class Circle:Program
    {
        public Circle(double Radius) {
            this.Radius = Radius;
                }
        public override double GetArea()
        {
            return Pi * Radius*Radius;
        }
    }
    public class Cone:Program
    {
        public Cone(double Radius,double Height)
        {
            this.Radius = Radius;
            this.Height = Height;
        }
        public override double GetArea()
        {
            return Radius * Pi*(Radius+Math.Sqrt(Height*Height+Radius*Radius));
        }
    }
    class TestProgram
    {
        static void Main()
        {
            Rectangle r = new Rectangle(85.5,85.5);
            Circle c = new Circle(10.10);
            Cone co = new Cone(100.1,100.1);
            Console.WriteLine("Area of Rectangle:" + r.GetArea());
            Console.WriteLine("Area of Circle:" + c.GetArea());
            Console.WriteLine("Area of Cone:" + co.GetArea());
        }
    }

}
