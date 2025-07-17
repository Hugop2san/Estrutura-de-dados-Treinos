using System;
using System.Globalization;
using treino.Entities;
using Treino.Entities;
using Treino.Services;
//using System.Text.Encoding;
namespace Treino
{
    class Program
    {
        static void Main(string[] args) 
        {

            Console.WriteLine("Enter contact data: ");
            Console.Write("Number : ");
            int number = int.Parse(Console.ReadLine());

            Console.Write("Date (dd/mm/yyyy) :");
            DateTime  date = DateTime.ParseExact(Console.ReadLine(), "dd/mm/yyyy",  CultureInfo.InvariantCulture);
        
            Console.Write("Contract Value : ");
            double value = double.Parse(Console.ReadLine() , CultureInfo.InvariantCulture);

            Console.Write("Enter number of installments: ");
            int instMonths = int.Parse(Console.ReadLine());

            Contract mycontract = new Contract(number, date , value  ); 

            ContractService contractservice = new ContractService( new PaypalService()  );
       
            contractservice.ProcessContract( mycontract,  instMonths);

            Console.WriteLine("Installments : ");
            foreach(Installment i in  mycontract.Installments )
            {
                Console.WriteLine( i );
            }
        
        
        }
    }   
}