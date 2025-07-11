using System;
using System.Globalization;
using Treino.Entities;
using Treino.Services;

//using System.Text.Encoding;

namespace Treino
{
    class Program
    {
        static void Main(string[] args) 
        {

            Console.WriteLine("Enter rental data");
            Console.Write("Car model: ");   
            Vehicle vehicle = new Vehicle(Console.ReadLine());

            Console.Write("Pick-up date (dd/MM/yyyy hh:mm): ");
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);

            Console.Write("Return date (dd/MM/yyyy hh:mm): ");
            DateTime returnDate = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
           
            Console.Write("Enter price per hour: ");
            double pricePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Enter price per day: ");
            double pricePerDay = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);



            CarRental carRental = new(start ,returnDate, vehicle );       
            
            RentalService rentalService = new(pricePerHour, pricePerDay);

            rentalService.ProcessInvoice(carRental);    //rentalservice chama o metodo processinvoice que recebe atributo do tipo carRental
            
            Console.WriteLine("INVOICE: ");
            Console.WriteLine(carRental.Invoice); 
            // carRental tem o atributo invoice que é do tipo Invoice, que por sua vez tem o método ToString() 
            // que retorna os valores formatados
        
        
        
        }
            
    }   
}