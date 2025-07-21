using System;

namespace Treino
{
    class Program
    {
        static void Main(string[] args) 
        {
            PrintService<int> printSer= new();
            
           Console.WriteLine("How many Values ?");
            int values= int.Parse(Console.ReadLine());

            for (int i=0; i < values; i++)
            {
                Console.WriteLine($"value {i} :");
                int value123= int.Parse(Console.ReadLine());
                printSer.AddValue(value123);
            }

            Console.WriteLine("Print values: ");
            printSer.Print();

            Console.WriteLine();

            Console.WriteLine("First value: ");
            Console.WriteLine(printSer.First());

        }
    }  
    class PrintService<T>
    {
        private T[] _values= new T[10]; 
        private int _count= 0;

        public void AddValue(T value) 
        {

           _values[_count]= value;
            _count++;
        }

        public T First()
        {
            return _values[0];
        }

        public void Print()
        {
            Console.Write("[");
            for(int i=0; i<_count-1; i++){Console.Write(_values[i]+",");}
            if(_count>0){ Console.Write(_values[_count-1]); } 
            Console.Write("]");
        }



    } 
}