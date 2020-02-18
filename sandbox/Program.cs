
using System;
namespace sandbox
{
  class Program
 {static void Main(string[] args)
        {
            Console.WriteLine("Skriv in ett tal");
            double tal1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Skriv in ett tal till");
            double tal2 = double.Parse(Console.ReadLine());

            double summa = tal1 + tal2;
            double produkt = tal1 * tal2;
            Console.WriteLine("Summan av talen är " + summa);
            Console.WriteLine("Produkten av talen är " + produkt);
            Console.ReadKey();
        }
    }
}