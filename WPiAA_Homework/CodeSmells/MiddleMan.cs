namespace RefactoringToDesignPatterns.CH01_CodeSmells.HomeWork
{
    internal class MiddleMan
    {
    }

    public class InvoiceRepository
    {
        public Invoice GetInvoiceById(int id)
        {
            throw new NotImplementedException();
        }

        public void SaveInvoice(Invoice invoice)
        {
            throw new NotImplementedException();
        }
    }

    public class Invoice
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }
    }
}
