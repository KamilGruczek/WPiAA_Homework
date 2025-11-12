namespace RefactoringToDesignPatterns.CH01_CodeSmells.HomeWork
{
    internal class PrimitiveObsession
    {
    }

    public class ProductManager
    {
        public void RegisterProduct(ProductDetails productDetails)
        {
            Console.WriteLine($"Product: {productDetails.Name}, Category: {productDetails.Category}, Price: {productDetails.Price}, Quantity: {productDetails.Quantity}");
        }
    }

    public class ProductDetails
    {
        public required string Name { get; set; }
        public required string Category { get; set; }
        public required decimal Price { get; set; }
        public required int Quantity { get; set; }
    }
}
