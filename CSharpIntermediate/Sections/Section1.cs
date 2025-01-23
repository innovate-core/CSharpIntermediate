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

    public static void Run()
    {
        Classes();
        Constructors();
        ObjectInitializers();
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

        var customer = new Customer(1,"Mykola");
        Console.WriteLine(customer.Id);
        Console.WriteLine(customer.Name);

        var order = new Order();
        customer.Orders.Add(order);

        Console.WriteLine("Finish -> Constructors");
    }

    private static void ObjectInitializers()
    {
    }

    private static void Methods()
    {
    }

    private static void Fields()
    {
    }
}
