using System;
using System.Collections.Generic;

namespace exercise_70
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
        if (input > 100)
        {
          break;
        }
        list.Add(input);
        if (input == 50)
        {
          break;
        }
        list.Add(input);
        ///extra just for fun!
      
      
      
      }
      int greatest = list[0];

      for(int i = 0; i < list.Count; i++) 
      {
        int number = list[i];
        if (greatest < number) 
        {
         greatest = number;
        }
      }
      Console.WriteLine("The greatest number: " + greatest);

    }
  }
}
