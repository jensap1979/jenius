﻿using System;

namespace exercise_44
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code here:
          int num1 = Convert.ToInt32(Console.ReadLine());
      int num2 = Convert.ToInt32(Console.ReadLine());
      if (num1 > num2)
      {
        Console.WriteLine(num1 + " is greater than " + num2 + ".");
      }
      else if (num1 < num2)
      {
        Console.WriteLine(num1 + " is less than " + num2 + ".");
      }
      else
      {
        Console.WriteLine(num1 + " is equal to "+ num2 + ".");
      }


    }
  }
}
