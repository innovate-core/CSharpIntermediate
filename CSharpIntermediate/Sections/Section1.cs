namespace CSharpIntermediate.Sections;

/// <summary>
/// Classes
/// </summary>
public static class Section1
{
    public class Person
    {
        public string Name;

        public void Introduce(string to)
        {
            Console.WriteLine("Hi {0}, I am {1}", to, Name);
        }

        public static Person Parse(string str)
        {
            var person = new Person();
            person.Name = str;

            return person;
        }
    }

    public class Customer
    {
        public int Id;
        public string Name;
        public List<Order> Orders;

        public Customer()
        {
            Orders = new List<Order>();
        }

        public Customer(int id) : this()
        {
            Id = id;
        }

        public Customer(int id, string name) : this(id)
        {
            Name = name;
        }
    }

    public class Order
    {
    }

    public class Point
    {
        public int X;
        public int Y;

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void Move(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void Move(Point newLocation)
        {
            if (newLocation is null)
                throw new ArgumentNullException(nameof(newLocation));

            //ArgumentNullException.ThrowIfNull(newLocation); // added in .Net 6 version

            Move(newLocation.X, newLocation.Y);
        }
    }

    public class Calculator
    {
        public int Add(params int[] values)
        {
            var sum = 0;
            foreach (var value in values)
                sum += value;

            return sum;
        }
    }

    public static void Run()
    {
        Classes();
        Constructors();
        Methods();
        Fields();
    }

    private static void Classes()
    {
        Console.WriteLine("Start ->  Introduction to Classes");

        var person = new Person();
        person.Name = "Mykola";
        person.Introduce("John"); //Output: Hi John, I am Mykola

        var person1 = Person.Parse("Mykola");
        person.Introduce("John"); //Output: Hi John, I am Mykola

        Console.WriteLine("Finish ->  Introduction to Classes");
    }

    private static void Constructors()
    {
        Console.WriteLine("Start -> Constructors");

        var customer = new Customer(1, "Mykola");
        Console.WriteLine(customer.Id);
        Console.WriteLine(customer.Name);

        var order = new Order();
        customer.Orders.Add(order);

        Console.WriteLine("Finish -> Constructors");
    }

    private static void Methods()
    {
        Console.WriteLine("Start -> Methods");

        try
        {
            var point = new Point(10, 20);
            point.Move(new Point(40, 60));
            point.Move(null);
            Console.WriteLine("Point is at ({0}, {1})", point.X, point.Y);

            point.Move(100, 200);
            Console.WriteLine("Point is at ({0}, {1})", point.X, point.Y);
        }
        catch (Exception)
        {
            Console.WriteLine("An unexpected error occured.");
        }

        var calculator = new Calculator();
        Console.WriteLine(calculator.Add(1, 2));
        Console.WriteLine(calculator.Add(1, 2, 3));
        Console.WriteLine(calculator.Add(1, 2, 3, 4));
        Console.WriteLine(calculator.Add(new int[] { 1, 2, 3, 4, 5 }));

        int number;
        var result = int.TryParse("abc", out number);

        if (result)
            Console.WriteLine(number);
        else
            Console.WriteLine("Conversion failed.");

        Console.WriteLine("Finish -> Methods");
    }

    private static void Fields()
    {
    }
}
