﻿using System;
using System.Collections.Generic;

namespace exercise_81
{
  class Program
  {
    public static void Main(string[] args)
    {
      // You can test your method here
      int[] array = {5, 1, 3, 4, 2};
      PrintNeatly(array);

    }

    public static void PrintNeatly(int[] array)
    {
      int index = 0;
      while (index < array.Length -1)
      {
        int number = array[index];
        Console.Write(number + ", ");
        index = index + 1;      
      }

       Console.Write(array[array.Length - 1] + "\n");
    }
    
  }
}

