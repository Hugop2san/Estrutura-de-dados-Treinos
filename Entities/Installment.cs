using System;
using System.Globalization;

namespace treino.Entities
{
    public class Installment
    {
        public DateTime DueDate { get; set; } //data de vencimento
        public double Amount { get; set; }    //valor da parcela

        public Installment(DateTime dueDate, double amount)
        {
            DueDate = dueDate;
            Amount = amount;
        }
        public override string ToString() {
            return DueDate.ToString("dd/MM/yyyy")
                + " - "
                + Amount.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}