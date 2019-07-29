using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Polymorphism
    {
        public class StaticFuncPoly
        {
            public int Add(int a, int b)
            {
                return a + b;
            }

            public int Add(int a, int b, int c)
            {
                return a + b + c;
            }

        }


    }

    class StaticOperPoly
    {
        private int a;
        private int b;
        private int c;

        public static StaticOperPoly operator +(StaticOperPoly a, StaticOperPoly b)
        {
            StaticOperPoly sp = new StaticOperPoly();
            sp.a = a.a + b.a;
            return sp;
        }

        public int A
        {
            get { return a; }
            set { a = value; }
        }

    }

    class Test
    {
        public void runCode()
        {
            StaticOperPoly s1 = new StaticOperPoly();
            StaticOperPoly s2 = new StaticOperPoly();

            s1.A = 3;
            s2.A = 4;

            StaticOperPoly s3 = s1 + s2;

            Console.WriteLine(s3.A);
        }
    }


    //              Dynamic Polymorphism
    //---------------------------------------
    //              Inheritance

    abstract class Shape
    {
        abstract public int area();
    }
    class Rectangle : Shape
    {
        private int length;
        private int width;
        public Rectangle(int a = 0, int b = 0)
        {
            length = a;
            width = b;
        }
        public override int area()
        {
            Console.WriteLine("Rectangle 类的面积：");
            return (width * length);
        }
    }

    class RectangleTester
    {
        static void test(string[] args)
        {
            Rectangle r = new Rectangle(10, 7);
            double a = r.area();
            Console.WriteLine("面积： {0}", a);
            Console.ReadKey();
        }
    }

    //----------------Interface----------------
    public interface PaintCost
    {
        int getCost(int area);
    }

    class Shape2
    {
        public void setWidth(int w)
        {
            width = w;
        }
        public void setHeight(int h)
        {
            height = h;
        }
        protected int width;
        protected int height;
    }

    class Rectangle2 : Shape2, PaintCost
    {
        public int getArea()
        {
            return (width * height);
        }
        public int getCost(int area)
        {
            return area * 70;
        }
    }

    /// <summary>
    /// Virtual
    /// </summary>
    class VirtualClass
    {
        public class Shape
        {
            public const double PI = Math.PI;
            protected double x, y;

            public Shape()
            {
            }

            public Shape(double x, double y)
            {
                this.x = x;
                this.y = y;
            }

            public virtual double Area()
            {
                return x * y;
            }
        }

        public class Circle : Shape
        {
            public Circle(double r) : base(r, 0)
            {
            }

            public override double Area()
            {
                return PI * x * x;
            }
        }

        class Sphere : Shape
        {
            public Sphere(double r) : base(r, 0)
            {
            }

            public override double Area()
            {
                return 4 * PI * x * x;
            }
        }

        class Cylinder : Shape
        {
            public Cylinder(double r, double h) : base(r, h)
            {
            }

            public override double Area()
            {
                return 2 * PI * x * x + 2 * PI * x * y;
            }
        }

        static void RunCode()
        {
            double r = 3.0, h = 5.0;
            Shape c = new Circle(r);
            Shape s = new Sphere(r);
            Shape l = new Cylinder(r, h);
            Shape m = new Shape(r, h);
            // Display results.
            Console.WriteLine("Area of Circle   = {0:F2}", c.Area());
            Console.WriteLine("Area of Sphere   = {0:F2}", s.Area());
            Console.WriteLine("Area of Cylinder = {0:F2}", l.Area());
            Console.WriteLine("Area of Shape = {0:F2}", m.Area());
        }
    }
}
