
namespace RefactoringToDesignPatterns.CH01_CodeSmells.HomeWork
{
    internal class Comments
    {
    }

    public class Transaction
    {
        public bool Validate()
        {

            return true;
        }
    }

    public class PaymentProcessor
    {
        public void PerformTransaction(Transaction transaction)
        {
            // Weryfikuje szczegóły transakcji
            if (ValidateTransactionDetails(transaction))
            {
                // Przeprowadza płatność
                ProcessTransactionPayment(transaction);

                // Aktualizuje stan konta
                UpdateAccountBalance(transaction);

                // Generuje potwierdzenie
                GenerateTransactionReceipt(transaction);
            }
        }

        private void GenerateTransactionReceipt(Transaction transaction)
        {
            throw new NotImplementedException();
        }

        private void UpdateAccountBalance(Transaction transaction)
        {
            throw new NotImplementedException();
        }

        private void ProcessTransactionPayment(Transaction transaction)
        {
            throw new NotImplementedException();
        }

        private bool ValidateTransactionDetails(Transaction transaction)
        {
            return transaction.Validate();
        }
    }
}
