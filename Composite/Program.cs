using Composite;

Console.WriteLine("Hello in Composite Restaurant.");

var menu = new MenuCategory("Main Menu");
var appetizers = new MenuCategory("Appetizers");
appetizers.AddSubItem(new Dish("Spring Rolls"));
appetizers.AddSubItem(new Dish("Garlic Bread"));
appetizers.AddSubItem(new Dish("Bruschetta"));
menu.AddSubItem(appetizers);

var mains = new MenuCategory("Main Dishes");
mains.AddSubItem(new Dish("Pizza"));
mains.AddSubItem(new Dish("Pasta"));
mains.AddSubItem(new Dish("Salad"));
menu.AddSubItem(mains);

var desserts = new MenuCategory("Desserts");
desserts.AddSubItem(new Dish("Ice Cream"));
desserts.AddSubItem(new Dish("Cake of the Day"));
menu.AddSubItem(desserts);

menu.Display();

Console.WriteLine("\nHave a beautiful day!");
Console.ReadKey();
