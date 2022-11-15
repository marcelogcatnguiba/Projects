﻿
namespace PayPal.Services
{
    internal class PayPalService : IOnlinePaymentService
    {
        private const double FeePercentagem = 0.02;
        private const double MonthlyInterest = 0.01;
        public double PaymentFee(double amount){
            return amount * FeePercentagem;
        }
        public double Interest( double amount, int months)
        {
            return amount * MonthlyInterest * months;
        }
    }
}
