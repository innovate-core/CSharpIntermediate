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

    public static void Run()
    {
        Classes();
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
}
