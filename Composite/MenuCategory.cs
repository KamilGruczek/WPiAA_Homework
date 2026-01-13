namespace Composite
{
    internal class MenuCategory(string name) : IMenuListItem
    {
        private List<IMenuListItem> _items = [];

        public void Display(int depth = 0)
        {
            var indent = new string(' ', depth * 2);
            Console.WriteLine($"{indent}{name}");
            foreach (var item in _items)
            {
                if (item is MenuCategory category)
                {
                    category.Display(depth + 1);
                }
                else
                {
                    (item as Dish)?.Display(depth + 1);
                }
            }
        }

        public void AddSubItem(IMenuListItem subItem)
        {
            ArgumentNullException.ThrowIfNull(subItem);
            _items.Add(subItem);
        }

        public void RemoveSubItem(IMenuListItem subItem)
        {
            ArgumentNullException.ThrowIfNull(subItem);
            _items.Remove(subItem);
        }
    }
}
