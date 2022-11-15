using PayPal.Entities;
using System;

namespace PayPal.Services
{
    internal class ContractService
    {
        private IOnlinePaymentService _onlinePaymentService;
        public ContractService(IOnlinePaymentService onlinePaymentService)
        {
            _onlinePaymentService = onlinePaymentService;
        }

        public void ProcessContract ( Contract contract, int mounth)
        {
            for (int i = 1; i <= mounth; i++)
            {
                DateTime dueDate = contract.Date.AddMonths(i);
                double amount = contract.TotalValue / mounth;

                amount += _onlinePaymentService.PaymentFee(amount);
                amount += _onlinePaymentService.Interest(amount,i);

                Installment installment = new Installment(dueDate, amount);

                contract.AddInstallment(installment);
                
            }
        }
    }
}
