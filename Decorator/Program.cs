Console.WriteLine("Hello in Decorator Shop.");

var shop = new Decorator.Shop();
var decoratedShop = new Decorator.Decorator(shop);
decoratedShop.PayByCash();
decoratedShop.PayByBlik();
decoratedShop.PayByCard();

Console.WriteLine("\nHave a beautiful day!");
Console.ReadKey();
