using System;
using Treino.Entities;
using System.Collections.Generic;
using treino.Entities;

namespace Treino.Services
{
    public class ContractService
    {
        private  IOnlinePaymentService _ionlinePaymentservice;

        public ContractService(IOnlinePaymentService ionlinePaymentservice)
        {
            _ionlinePaymentservice = ionlinePaymentservice ;
        }
        public void ProcessContract(Contract contract, int months)
        {
            double basicquota = contract.TotalValue/months ;
            for (int i=0; i<months; i++)
            {
                DateTime datemonths = contract.Date.AddMonths(i);
                double updatequota = basicquota + _ionlinePaymentservice.Interest(basicquota, i); // aliquota basica 1 % * mes
                double fullquota = updatequota + _ionlinePaymentservice.PaymentFee(updatequota); // aliquota com impostos * taxa de transferencia
                contract.AddInstallment(new Installment (datemonths , fullquota));
            }
        }
    
    
    
    }
}