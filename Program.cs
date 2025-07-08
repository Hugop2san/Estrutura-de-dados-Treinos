using System;
using Treino.Entities;
using System.Globalization;

namespace Treino
{
    class Program
    {
        static void Main(string[] args) 
        {
            


            Console.WriteLine("Enter account data");
            
            int number = 2030;
            Console.Write("Number: "+number);
            
            string holder = "Hugo santos";
            Console.WriteLine("Holder: "+ holder);
            
            Console.WriteLine("Initial balance: ");
            double balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture) ;
            
            //double withdrawLimit = 500.00;
            Console.WriteLine("Withdraw limit: 1k");

            Account account = new Account(number, holder, balance);


            Console.WriteLine();
            Console.WriteLine("account data:");
            Console.WriteLine($"Number {account.Number}, \nHolder: {account.Holder}, \nBalance: {account.Balance.ToString("F2", new CultureInfo("pt-BR"))}, \nWithdraw Limit {account.WithdrawLimit.ToString("F2", new CultureInfo("pt-BR"))}");

            Console.WriteLine();
            Console.Write("Enter amount for withdraw: ");
            double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            try
            {
                account.Withdraw(amount);
                Console.WriteLine($"New balance: {account.Balance.ToString("F2", new CultureInfo("pt-BR"))}");
            }
            catch (ArgumentException e)
            {
                Console.WriteLine($"Withdraw error: {e.Message}");
            }
            catch (FormatException e)
            {
                Console.WriteLine($"Input error: {e.Message}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Unexpected error: {e.Message}");
            }
        }
    }   
}