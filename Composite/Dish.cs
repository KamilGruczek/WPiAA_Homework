namespace Composite
{
    internal class Dish(string name) : IMenuListItem
    {
        public void Display(int depth = 0)
        {
            var indent = new string(' ', depth * 2);
            Console.WriteLine($"{indent} - {name}");
        }
    }
}
