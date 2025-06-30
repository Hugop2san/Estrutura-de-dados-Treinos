using System;
using MeuProjeto.Entidades.Enums;

namespace MeuProjeto.Entities { 
    class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public Orderstatus Status { get; set; }

     
    }
}