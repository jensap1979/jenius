using System;

namespace exercise_36
{
  class Program
  {
    public static void Main(string[] args)
    {
      while (true) //code
      
      { 
       Console.WriteLine("Give a number:");
       int userNmb = Convert.ToInt32(Console.ReadLine());
      

        if (userNmb == 0)
        {
        break;
        }
        else if (userNmb > 0)
        {
        Console.WriteLine(userNmb * userNmb);
        }
        else if (userNmb < 0)

        {
        Console.WriteLine("That is negative");
        }
      }
       
    } 
  }
} 