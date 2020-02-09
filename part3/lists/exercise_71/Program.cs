using System;
using System.Collections.Generic;

namespace exercise_71
{
  class Program
  {
    public static void Main(string[] args)
    {
      List<int> list = new List<int>();
      while (true)
        {
        int input = Convert.ToInt32(Console.ReadLine());
        if (input == -1)
          {
            break;
          }
        list.Add(input);
      
        }
       

       Console.WriteLine("Search for?");
       int minimum = Convert.ToInt32(Console.ReadLine());

       for (int index = 0; index < list.Count; index++)
        {
         if (list[index] == minimum)
          {
           Console.WriteLine(minimum + " is at index " + index);
          }
        }
      
    }
  }
}
