using System;
using System.Globalization;
using Treino.Entities;
using Treino.Services;

namespace Treino
{
    class Program
    {
        static void Main(string[] args) 
        {
            List<Produto> listaprodutos= new List<Produto> ();

            Console.WriteLine("Enter N Values :");
            int values= int.Parse(Console.ReadLine()) ;
            
            for(int i =0; i < values; i++)
            {
                Console.Write("Name of product and price (TV,1500.50) :");
                string[] vect = Console.ReadLine().Split(',') ;
                string name= vect[0];
                double price= double.Parse(vect[1], CultureInfo.InvariantCulture);

                listaprodutos.Add(new Produto(name , price)); //
            }
            // Exibindo o mais caro!
            Console.WriteLine("Exibindo o mais caro!");

            //Produto max = new Produto (); 
            CalculationService maxcalc= new();

             
            Produto max = maxcalc.Max(listaprodutos);
            Console.WriteLine( "Nome: "+max.Name + " Preço: "+max.Price );
                
            

        }
    }  


    
}