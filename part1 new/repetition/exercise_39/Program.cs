using System;

namespace exercise_39
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Write your code here:
      
      int sum = 0;
      while (true)
      {
        Console.WriteLine("Give a number:");
        int userNmb = Convert.ToInt32(Console.ReadLine());
        if (userNmb == 0)
        {
          break;
        }
        else 
        {
        sum = sum + userNmb;
        }
      }  
      Console.WriteLine("Total sum of numbers: " + sum);
      
    }

  }
}
