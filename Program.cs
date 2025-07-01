using System;
using MeuProjeto.Entities;
using MeuProjeto.Entidades.Enums;

namespace MeuProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Worker worker = new Worker(); // global scope for Worker
            WorkLevel level = new(); // global scope for WorkLevel

            Console.Write("Enter department's name: ");
            string DepName = Console.ReadLine() ?? string.Empty;

            Console.Write("Enter worker data: ");

            Console.Write("Name: ");
            string Name = Console.ReadLine() ?? string.Empty;

            Console.Write("Level (Junior/MidLevel/Senior): ");
            string? levelInput = Console.ReadLine() ;
            if(Enum.TryParse(levelInput, true, out WorkLevel parsedlevel))
            { level = parsedlevel ;   }

            Console.Write("Base salary: ");
            double baseSalary = double.Parse(Console.ReadLine()) ;

            Console.WriteLine("How many contracts ? ");
            int n = int.Parse(Console.ReadLine());      //quantidade de contratos

            HourContract contracts = new ();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Enter #{i + 1} contract data: ");
                Console.Write("Date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());

                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine());

                Console.Write("Duration (hours): ");
                int hours = int.Parse(Console.ReadLine());

                contracts = new HourContract
                {
                    Date = date,
                    ValuePerHour = valuePerHour,
                    Hours = hours
                };

            }

            worker = new Worker{ Name=Name, Level = level , BaseSalary = baseSalary, Departament = new Departament { Name = DepName } };



            Console.WriteLine("Worker: " + worker);
        }

       
    }
}
