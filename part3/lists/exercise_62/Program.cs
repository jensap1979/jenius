using System;
using System.Collections.Generic;


namespace exercise_62
{
  class Program
  {
    public static void Main(string[] args)
    {
      List <string> wordList = new List<string>();

      while (true)
      {
        string input = Console.ReadLine();
        if (input == "")
        {
          break;
        }
        
        
        wordList.Add(input);
        
      }

      // BEGIN SOLUTION
      Console.WriteLine (wordList[2]);
 

      // END SOLUTION
    }

  }
}
