using System;
using Treino.Entities;


namespace Treino.Services
{

    public class CalculationService
    {
        //List<Produto> produto = new List<Produto>();

        public T Max<T> (List<T> produto)  where T : IComparable
        {

            if (produto.Count == 0)
            {
                throw new ArgumentException("The list can't be empty.");
            }

            T max =produto[0];
            for(int i=1; i<produto.Count ; i++ )
            {
                if (produto[i].CompareTo(max) > 0)
                {
                    max= produto[i];
                }
            }
            return max ;
        }



    }
}