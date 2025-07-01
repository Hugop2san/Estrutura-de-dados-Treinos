using System;
using MeuProjeto.Entidades.Enums;
using System.Globalization;

namespace MeuProjeto.Entities { 
    class Worker
    {
        public string Name { get; set; } = String.Empty;
        public WorkLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Departament Departament { get; set; } = new();
        public HourContract Contracts { get; set; } = new();


        public void AddContract(HourContract contract)
        {
            BaseSalary += contract.Totalvalue();   
        }
        
        public void RemoveContract(HourContract contract)
        {
            BaseSalary -= contract.Totalvalue();   
        }
        public double Income(int year, int month)
        {
            double sum = BaseSalary;
            // Aqui você pode adicionar a lógica para calcular a renda com base nos contratos
            return sum;
        }
     
        public override string ToString()
        {
            return $"Worker: {Name}, Level: {Level}, Base Salary: {BaseSalary.ToString("C", CultureInfo.CurrentCulture)}\n" +
                   $"Department: {Departament.Name}\n" +
                   $"Contracts: {Contracts}";
        }
    }
}