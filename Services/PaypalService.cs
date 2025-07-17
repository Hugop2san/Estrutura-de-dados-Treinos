namespace Treino.Services
{
    public class PaypalService : IOnlinePaymentService
    {
        private const double feepermonth= 0.01;
        private const double paymntfee = 0.02;
        public double Interest(double amount, int months)
        {
            return amount * months * feepermonth; // 1% per month
        }

        public double PaymentFee(double amount)
        {
            return amount* paymntfee; // 2% fee
        } 
    }
}