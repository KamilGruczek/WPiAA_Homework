namespace RefactoringToDesignPatterns.CH01_CodeSmells.HomeWork
{
    internal class LongParameterList
    {
        public static void RegisterProduct(ProductInfo productInfo)
        {
            // Rejestracja produktu
            Console.WriteLine($"Product: {productInfo.ProductName}, Category: {productInfo.Category}, Price: {productInfo.Price:C}, Stock: {productInfo.Stock}, Supplier: {productInfo.SupplierName}, Contact: {productInfo.SupplierContact}");
        }
    }

    internal class ProductInfo
    {
        public required string ProductName { get; set; }
        public required string Category { get; set; }
        public required decimal Price { get; set; }
        public required int Stock { get; set; }
        public required string SupplierName { get; set; }
        public required string SupplierContact { get; set; }
    }
}
