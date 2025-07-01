using MeuProjeto.Entities;

namespace MeuProjeto.Entidades.Enums
{
    class HourContract
    {
        public DateTime Date { get; set; } 
        public double ValuePerHour { get; set; } = 0.0;
        public int  Hours { get; set; } = 0 ;

        public double  Totalvalue() 
        {
            return ValuePerHour * Hours;
        }
        public override string ToString()
        {
            return $"Receipts for hours :\n Date: {Date.ToShortDateString()}, \nValue per hour: {ValuePerHour:C}, \nHours: {Hours}, \nTotal: {Totalvalue():C}";
        }
    }
}