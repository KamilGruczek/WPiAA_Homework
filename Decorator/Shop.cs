namespace Decorator
{
    internal class Shop
    {
        internal void PayByCash()
        {
            Console.WriteLine("Payed by cash");
        }

        internal void PayByBlik()
        {
            Console.WriteLine("Payed by Blik");
        }

        internal void PayByCard()
        {
            Console.WriteLine("Payed by card");
        }
    }
}
