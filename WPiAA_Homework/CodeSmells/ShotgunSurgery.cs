namespace RefactoringToDesignPatterns.CH01_CodeSmells.HomeWork
{
    internal class ShotgunSurgery
    {
    }

    public class Customer
    {
        public string Name { get; set; }
    }

    public class Order
    {
        public string OrderId { get; set; }

    }

    public class OrderService
    {
        public Order CreateOrder(Customer customer, Order order)
        {
            var oder = SaveOrder();

            Console.WriteLine($"Order created for customer {customer.Name}.");

            return order;
        }

        public Order SaveOrder()
        {
            var order = new Order();
            Console.WriteLine($"Order {order.OrderId} saved.");

            return order;
        }
    }
}
