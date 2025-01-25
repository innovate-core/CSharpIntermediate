namespace CSharpIntermediate.Sections;

public class Section2
{
    public class PresentationObject
    {
        public int Widht { get; set; }
        public int Height { get; set; }

        public void Copy()
        {
            Console.WriteLine("Object copied to clipboard");
        }

        public void Duplicate()
        {
            Console.WriteLine("Object was duplicate");
        }
    }

    public class Text : PresentationObject
    {
        public int FontSize { get; set; }
        public string FontName { get; set; }

        public void AddHyperlink(string url)
        {
            Console.WriteLine("We added a link to " + url);
        }
    }

    public static void Run()
    {
        Inheritance();
    }

    public static void Inheritance()
    {
        Console.WriteLine("Start -> Inheritance");
        
        var text = new Text();
        text.Widht = 1;
        text.Copy(); //Output: Object copied to clipboard

        Console.WriteLine("Finish -> Inheritance");
    }
}