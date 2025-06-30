using System;
using MeuProjeto.Entities;
using MeuProjeto.Entidades.Enums;

namespace MeuProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random= new();
            int i = random.Next(1, 5);
            Orderstatus status = i switch{
                1 => Orderstatus.Pending,
                2 => Orderstatus.Processing,
                3 => Orderstatus.Shipped,
                4 => Orderstatus.Delivered,
                5 => Orderstatus.Cancelled,
                _ => throw new ArgumentOutOfRangeException ("Invalid order status")
            };

            Order order = new Order { Id = i , OrderDate = DateTime.Now, Status = Orderstatus.Processing };

            PrintOrder(order);
        }

        static void PrintOrder(Order order)
        {
            Console.WriteLine($"Order ID: {order.Id}");
            Console.WriteLine($"Order Date: {order.OrderDate}");
            Console.WriteLine($"Order Status: {order.Status}");
        }
    }
}
