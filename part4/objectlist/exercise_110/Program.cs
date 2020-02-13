using System;
using System.Collections.Generic;

namespace exercise_110
{
  class Program
  {
    public static void Main(string[] args)
    {
      // IMPLEMENT YOUR CODE IN HERE!
      List<namelist> names = new List<namelist>();

      while (true)
      {
        Console.Write("Name:");
        String name = Console.ReadLine();
        if(name == "")
        {
          break;
        }
        names.Add(new namelist(name));
        {}
      
      }


    }
  }
}




