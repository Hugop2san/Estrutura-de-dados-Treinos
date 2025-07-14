using System;
using Treino.Entities;
using Math=System.Math;

namespace Treino.Services
{
    public class RentalService
    {
         public double PricePerHour { get; private set; }
        public double PricePerDay { get; private set; }
        private ITaxService _TaxService ; 
        public RentalService(double pricePerHour, double pricePerDay, ITaxService taxservice) {
            PricePerHour = pricePerHour;
            PricePerDay = pricePerDay;
            _TaxService = taxservice;    
        }

               
        
        public void ProcessInvoice(CarRental carrental) // condicionais das regras de negocio
        {
            TimeSpan duration = carrental.Finish.Subtract(carrental.Start);
            double hours = duration.TotalHours;

            double basicPayment = 0.0;
            if(hours <= 12)
            {
                basicPayment = PricePerHour * Math.Ceiling(hours);
                
            }
            else
            {
                basicPayment = PricePerDay * Math.Ceiling(duration.TotalDays);
            }

            double tax = _TaxService.Tax(basicPayment);

            carrental.Invoice = new Invoice(basicPayment, tax);
        }

    }
}