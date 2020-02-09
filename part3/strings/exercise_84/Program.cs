using System;
using System.Collections.Generic;

namespace exercise_84
{
  class Program
  {
    public static void Main(string[] args)
    {
      
      string right = "true";
      string name = Console.ReadLine(); 
      
    
       Console.Write("Give a string: ");
      if (name == right)
      {
        Console.Write("You got it right!\n");
      }
      else
      {
        Console.Write("Try again!\n");
      }



    }
  }
}

