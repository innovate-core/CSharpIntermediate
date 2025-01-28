using static CSharpIntermediate.Sections.Section5;

namespace CSharpIntermediate.Sections;

/// <summary>
/// Interfaces
/// </summary>
public static class Section5
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime DatePlaced { get; set; }
        public Shipment Shipment { get; set; }
        public float TotalPrice { get; set; }

        public bool IsShipped
        {
            get { return Shipment != null; }
        }
    }

    public class Shipment
    {
        public float Cost { get; set; }
        public DateTime ShippingDate { get; set; }
    }

    public interface IShippingCalculator
    {
        float CalculateShipping(Order order);
    }

    public class ShippingCalculator : IShippingCalculator
    {
        public float CalculateShipping(Order order)
        {
            if (order.TotalPrice < 30f)
                return order.TotalPrice * 0.1f;

            return 0;
        }
    }

    public class OrderProcessor
    {
        private readonly IShippingCalculator _shippingCalculator;

        public OrderProcessor(IShippingCalculator shippingCalculator)
        {
            _shippingCalculator = shippingCalculator;
        }

        public void Process(Order order)
        {
            if (order.IsShipped)
                throw new InvalidOperationException("This order is already processed.");

            order.Shipment = new Shipment
            {
                Cost = _shippingCalculator.CalculateShipping(order),
                ShippingDate = DateTime.Today.AddDays(1)
            };
        }
    }

    public static void Run()
    {
        InterfacesAndTestability();
    }

    private static void InterfacesAndTestability()
    {
        Console.WriteLine("Start -> Interfaces and Testability");

        var orderProcessor = new OrderProcessor(new ShippingCalculator());
        var order = new Order { DatePlaced = DateTime.Now, TotalPrice = 100f };
        orderProcessor.Process(order);

        Console.WriteLine("Finish -> Interfaces and Testability");
    }
}
