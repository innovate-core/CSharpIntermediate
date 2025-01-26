namespace CSharpIntermediate.Sections;

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

    public static void Run()
    {
        MethodOverriding();
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
}
