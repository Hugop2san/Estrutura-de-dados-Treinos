using System;
using System.Globalization;
using System.Collections.Generic;


namespace TreinoHugo
{
    class Program
    {

        static void Main(string[] args)
        {
            List<Funcionario> f =new();
            Random random = new Random(); // numesro aleario para o ID do funcionário


            Console.Write("How many employees will be registered? ");
            int n = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            for(int i=0; i<n; i++)
            {
                Console.WriteLine($"Employee #{i+1}:");
                //List<Funcionario> f = new();

                Console.Write("Id: ");
                int id = random.Next(1, 10);
                Console.Write(id);

                Console.WriteLine();
                
                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Salary: ");
                double salary = double.Parse( Console.ReadLine(), CultureInfo.InvariantCulture) ;

                bool idexistente = f.Any(x => x.Id == id);
                //ArgumentNullException

                if(string.IsNullOrWhiteSpace(name))
                {
                    Console.WriteLine("Error: Name cannot be empty and salary must be greater than zero.");
                    continue; 
                    // passa para a próxima iteração do loop(tratamento de nulo)
                } 
                else if ( idexistente== false )
                {
                    f.Add(new Funcionario{Id=id, Nome=name, Salario=salary});
                    Console.WriteLine("Employee registered successfully!");
                }
                else
                {Console.WriteLine("Error: Employee already exists with this ID.");}
                
            }

            foreach(Funcionario funcionario in f)
            {
                Console.WriteLine($"Id: {funcionario.Id}, Name: {funcionario.Nome}, Salary: {funcionario.Salario.ToString("F2", CultureInfo.InvariantCulture)}");
            }

            Console.WriteLine("Enter the employee id that will have salary increase :");
            
            int idbusca = int.Parse(Console.ReadLine());

            // metodo Find para buscar o funcionário pelo ID, porem cria-se uma nova referência
            Funcionario sucesso= f.Find(x => x.Id == idbusca ); 

            if (sucesso != null)
            {
                Console.WriteLine("Enter the percentage to increse: ");
                double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                sucesso.Aumentosalario(porcentagem);
            }

            Console.WriteLine("Updated list of employees:");
            foreach(Funcionario funcionario in f)
            {
                Console.WriteLine($"Id: {funcionario.Id}, Name: {funcionario.Nome}, Salary: {funcionario.Salario.ToString("F2", CultureInfo.InvariantCulture)}");
            }

        }


    }
}
