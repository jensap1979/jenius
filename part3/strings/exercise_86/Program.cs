using System;
using System.Collections.Generic;

namespace exercise_86
{
  class Program
  {
      public static void Main(string[] args)
     {
      while (true)
       {   
         String input = Console.ReadLine();
         if (input == "")
         {
         break;
         }  

         string[] pieces = input.Split(" "); 
    
         for (int i = 0; i < pieces.Length; i++)
          {
            Console.WriteLine(pieces[i]);
          }
        }
      }

  }
}

