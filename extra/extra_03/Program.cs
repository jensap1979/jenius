﻿using System;
using System.Collections.Generic;

namespace extra_03
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Add your code here:


      // numbers we want answers on
      int sum = 0;
      int total = 1; // can't multiply with zero
      int userNumbers = 0;
      double average = 0;

      // ask user how many numbers
      Console.WriteLine("How many numbers?");
      int numAmount = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine("Give " + numAmount + " numbers:");

      // make list for the numbers
      List<int> numbers = new List<int>();

      // add users numbers to the list

      // for (int i = 0; i < numAmount; i++)
      // {
      //   userNumbers = Convert.ToInt32(Console.ReadLine());
      //   numbers.Add(userNumbers);
      // }

      // doing it with a while loop is a bit clearer, but for loop looks more tidy
      int i = 0;
      while (i < numAmount)
      {
        userNumbers = Convert.ToInt32(Console.ReadLine());
        numbers.Add(userNumbers);
        i++;
      }

      // do some calculations (foreach goes through every item, in this case number (int, but can also be a string), in the list)
      foreach (int number in numbers)
      {
        sum = number + sum;
        total = number * total;
        average = sum / (double)numAmount; // we want decimals in our average (double)
      }

      // print number stats
      Console.WriteLine("Their sum: " + sum);
      Console.WriteLine("Their total: " + total);
      Console.WriteLine("Their average: " + average);
    }
  }
}