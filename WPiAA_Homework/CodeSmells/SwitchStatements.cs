namespace RefactoringToDesignPatterns.CH01_CodeSmells.HomeWork
{
    internal class SwitchStatements
    {
        public class Payment
        {
            public IPaymentFeeStrategy PaymentMethod { get; set; }

            public decimal DeterminePaymentFee(decimal amount)
            {
                return PaymentMethod.DeterminePaymentFee(amount);
            }
        }

        public interface IPaymentFeeStrategy
        {
            decimal DeterminePaymentFee(decimal amount);
        }

        public class CreditCardFeeStrategy : IPaymentFeeStrategy
        {
            public decimal DeterminePaymentFee(decimal amount)
            {
                return amount * 0.02m;
            }
        }

        public class PayPalFeeStrategy : IPaymentFeeStrategy
        {
            public decimal DeterminePaymentFee(decimal amount)
            {
                return amount * 0.03m;
            }
        }

        public class BankTransferFeeStrategy : IPaymentFeeStrategy
        {
            public decimal DeterminePaymentFee(decimal amount)
            {
                return amount * 0.01m;
            }
        }
    }
}
