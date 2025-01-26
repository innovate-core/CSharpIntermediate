namespace CSharpIntermediate.Sections;

public class Section3
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Promote()
        {
            var rating = CalculateRating(excludeOrders: true);
            if (rating == 0)
                Console.WriteLine("Promoted to Level 1");
            else
                Console.WriteLine("Promoted to Level 2");
        }

        private int CalculateRating(bool excludeOrders)
        {
            return 0;
        }
    }

    public class GoldCustomer : Customer
    {
        public void OfferVouchar()
        {
            this.Promote();
        }
    }

    public static void Run()
    {
        AccessModifiers();
    }

    private static void AccessModifiers()
    {
        Console.WriteLine("Start -> Access Modifiers");

        var customer = new Customer();
        customer.Promote();
        //customer.CalculateRating();

        Console.WriteLine("Finish -> Access Modifiers");
    }
}