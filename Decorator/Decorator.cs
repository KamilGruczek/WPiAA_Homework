namespace Decorator
{
    internal class Decorator(Shop shop)
    {
        internal void PayByCash()
        {
            shop.PayByCash();
        }

        internal void PayByBlik()
        {
            shop.PayByBlik();
        }

        internal void PayByCard()
        {
            Console.WriteLine("Starting card payment decoration...");
            shop.PayByCard();
            SMSNotification();
            LoyaltyPointsAdd();
            RedirectToMainPage();
            Console.WriteLine("Finished card payment decoration.");
        }

        private void SMSNotification()
        {
            Console.WriteLine("[SMS Notification] - Your payment has been processed.");
        }

        private void LoyaltyPointsAdd()
        {
            Console.WriteLine("[Loyalty Points] - Points have been added.");
        }

        private void RedirectToMainPage()
        {
            Console.WriteLine("[Redirect] - Returning to the main page.");
        }
    }
}
