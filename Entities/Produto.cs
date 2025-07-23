
namespace Treino.Entities
{

    public class Produto : IComparable
    {
        public string Name{get; set;}
        public double Price{get; set;}

        public Produto(){}

        public Produto(string name, double price){ Name= name; Price=price;}

        public int CompareTo(object outro)
        {
            if (outro is null){ throw new ArgumentException("This s not a Produto type.");}
            
            Produto other = outro as Produto;

            return Price.CompareTo(other.Price);
        }

    }
}