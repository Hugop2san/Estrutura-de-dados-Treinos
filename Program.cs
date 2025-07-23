using System;
using Treino.Entities;
using Treino.Services;

namespace Treino
{
    class Program
    {
        static void Main(string[] args) 
        {
            string name= "Hugo santos";

            Client a = new Client {Name = name, Email ="hugo@gmail.com"}; 
            Client b = new Client {Name = "Juliana", Email ="Juliana@gmail.com"}; 

            Console.WriteLine(  a.Equals(b) );  // Realizando comparacao por conteudo do objeto >> email
            Console.WriteLine(  a.GetHashCode() );  // capturando o hashcode da referendcia
            Console.WriteLine(  b.GetHashCode() );
            

        }
    }  


    
}