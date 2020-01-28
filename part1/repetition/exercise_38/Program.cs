using System;

namespace exercise_38
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:
     int negnum = 0;
     while (true)
      {
        Console.WriteLine("Give a number:");
        int numero = Convert.ToInt32(Console.ReadLine());
      
        
        if (numero == 0)
        {
        break;
        }
        else if (numero < 0);
        {
         negnum = negnum +2;
         }
         
         
      
      }
      Console.WriteLine("Total amount of negative numbers: " + negnum);
    }
  }
}
