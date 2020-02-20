using System;

namespace exercise_40
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
      int sum = 0;
      int amount = 0;
      while (true)
      {
        Console.WriteLine("Give a number");
        int numero = Convert.ToInt32(Console.ReadLine());
        if (numero == 0)
        {
          break;
        }
        else
        {
         sum = sum + numero;  
         amount++; 
        }
      }
      Console.WriteLine("Total sum of numbers: " + sum);
      Console.WriteLine("Total amount of numbers: " + amount);
    } 
  }
}
