using System;
using System.Drawing;

namespace Basics
{
    public class PatternMatching : ISample
    {
        public void Run()
        {
            Console.WriteLine(ComputeAreaModernSwitch(new Rectangle(8,9)));
           
            Console.WriteLine(AssignSwitchExpression(Color.Green));
            Console.WriteLine(CreateShape("circle"));

            Console.WriteLine(CreateShape("   "));
            Console.WriteLine(CreateShape(null));

            Console.WriteLine(CreateShape(" test "));

            TypeTestPattern();
            ExpressingPattern();

        }

        public static double ComputeAreaModernSwitch(object shape)
        {
            switch (shape)
            {
                case Square s:
                    return s.Side * s.Side;
                case Circle c:
                    return c.Radius * c.Radius * Math.PI;
                case Rectangle r:
                    return r.Height * r.Length;
                default:
                    throw new ArgumentException(
                        "shape is not a recognized shape",
                        nameof(shape));
            }
        }

        public string AssignSwitchExpression(Color color)
        {
            return color switch
            {
                Color.Black => "choosed black color",
                Color.Blue => "choosed blue color",
                _ => "choosed color other that black or blue"
            };
        }

        private static object CreateShape(string shapeDescription)
        {
            switch (shapeDescription)
            {
                case "circle":
                    return new Circle(2);

                case "square":
                    return new Square(4);

                case "large-circle":
                    return new Circle(12);

                case var o when (o?.Trim().Length ?? 0) == 0:
                    // white space
                    return null;
                default:
                    return "invalid shape description";
            }
        }

        public static double ComputeArea_Version4(object shape)
        {
            switch (shape)
            {
                case Square s when s.Side == 0:
                case Circle c when c.Radius == 0:
                case Triangle t when t.Base == 0 || t.Height == 0:
                case Rectangle r when r.Length == 0 || r.Height == 0:
                    return 0;

                case Square s:
                    return s.Side * s.Side;
                case Circle c:
                    return c.Radius * c.Radius * Math.PI;
                case Triangle t:
                    return t.Base * t.Height / 2;
                case Rectangle r:
                    return r.Length * r.Height;
                default:
                    throw new ArgumentException(
                        message: "shape is not a recognized shape",
                        paramName: nameof(shape));
            }
        }

        public void TypeTestPattern()
        {
            Fruit fruit = new Fruit();
            var test = fruit switch
            {
                Apple _ => "This is an apple", // discarded apple variable
                _ => "This is not an apple"
            };

            bool? visible = false;
            var visibility = visible switch
            {
                true => "Visible",
                false => "Hidden",
                null => "Blink"
            };

            Console.WriteLine(test);
        }

        public void ExpressingPattern()
        {
            Fruit fruit = new Apple()
            {
               Color = Color.Green
            };

            var message = fruit switch
            {
                { Color: Color.Green } => "healthy green apple",
                { Color: Color.Red } => "delicious red apple ",
                _ => "apple is rotten"
            };
            Console.WriteLine(message);
        }


        public class Fruit
        {
            public Color Color { get; set; }
        }
        public class Apple : Fruit
        {
            
        }

        public enum Color
        {
            Red,
            Green,
            Blue,
            Black
        }

        public class Square
        {
            public Square(double side)
            {
                Side = side;
            }

            public double Side { get; }
        }

        public class Circle
        {
            public Circle(double radius)
            {
                Radius = radius;
            }

            public double Radius { get; }
        }

        public struct Rectangle
        {
            public double Length { get; }
            public double Height { get; }

            public Rectangle(double length, double height)
            {
                Length = length;
                Height = height;
            }
        }

        public class Triangle
        {
            public Triangle(double @base, double height)
            {
                Base = @base;
                Height = height;
            }

            public double Base { get; }
            public double Height { get; }
        }
    }
}