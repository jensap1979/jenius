using System;

namespace extra_02
{
  class Program
  {
    public static void Main(string[] args)
    {
      // Add your code here:

      // ask user for three numbers
      Console.WriteLine("Give three numbers:");
      int numbOne = Convert.ToInt32;
      Console.ReadLine();
      
      int numbTwo = Convert.ToInt32;
      Console.ReadLine();
      
      int numbThree = Convert.ToInt32;
      Console.ReadLine();
      // find the largest number and print it
      if (numbOne > numbTwo && numbOne > numbThree)
      {
        Console.WriteLine("Largest: " + numbOne);
      }
      else if (numbTwo > numbOne && numbTwo > numbThree)
      {
        Console.WriteLine("Largest: " + numbTwo);
      }
      else 
      {
        Console.WriteLine("Largest: " + numbThree);
      }
    }
  }
}