﻿using System;

namespace exercise_16
{
  class Program
  {
    public static void Main(string[] args)
    {

      // Write your code
      int secondsDay = 60 * 60 * 24;
      Console.WriteLine("How many days?");
      string userInput = Console.ReadLine();

      int intValue = Convert.ToInt32(userInput);

      Console.WriteLine(secondsDay * intValue);

    }
  }
}
