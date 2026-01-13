Console.WriteLine("Hello in Bridge OS App.");

var shop = new Decorator.Shop();
var decoratedShop = new Decorator.Decorator(shop);
decoratedShop.PayByCash();
decoratedShop.PayByBlik();
decoratedShop.PayByCard();

Console.WriteLine("\nHave a beautiful day!");
Console.ReadKey();
