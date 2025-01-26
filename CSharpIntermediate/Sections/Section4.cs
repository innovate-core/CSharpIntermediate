﻿namespace CSharpIntermediate.Sections;

/// <summary>
/// Polymorphism: Third Pillar of OOP
/// </summary>
public static class Section4
{
    public class Shape
    {
        public int Widht { get; set; }
        public int Height { get; set; }

        public virtual void Draw()
        {
        }
    }

    public class Canvas
    {
        public void DrawShapes(List<Shape> shapes)
        {
            foreach (var shape in shapes)
            {
                shape.Draw();
            }
        }
    }

    public class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Draw a circle");
        }
    }

    public class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Draw a rectangle.");
        }
    }

    public class Triangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Draw a triangle.");
        }
    }

    /////////////////////////////////////////////////////////////////////////////////////////////

    public abstract class Shape1
    {
        public int Widht { get; set; }
        public int Height { get; set; }

        public abstract void Draw();

        public void Copy()
        {
            Console.WriteLine("Copy shape into clipboard.");
        }

        public void Select()
        {
            Console.WriteLine("Select the shape");
        }
    }

    public class Circle1 : Shape1
    {
        public override void Draw()
        {
            Console.WriteLine("Draw a circle");
        }
    }

    public class Rectangle1 : Shape1
    {
        public override void Draw()
        {
            Console.WriteLine("Draw a rectangle.");
        }
    }

    public static void Run()
    {
        MethodOverriding();
        AbstractClassesAndMembers();
    }

    private static void MethodOverriding()
    {
        Console.WriteLine("Start -> Method Overriding");

        var shapes = new List<Shape>();
        shapes.Add(new Circle());
        shapes.Add(new Rectangle());
        shapes.Add(new Triangle());

        var canvas = new Canvas();
        canvas.DrawShapes(shapes);

        Console.WriteLine("Finish -> Method Overriding");
    }

    private static void AbstractClassesAndMembers()
    {
        Console.WriteLine("Start -> Abstract Classes and Members");

        var circle = new Circle1();
        circle.Draw();

        var rectangle  = new Rectangle1();
        rectangle.Draw();

        Console.WriteLine("Finish -> 29. Abstract Classes and Members");
    }
}
