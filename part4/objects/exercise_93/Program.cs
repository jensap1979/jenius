using System;

namespace exercise_93
{
  class Program
  {
    public static void Main(string[] args)
    {
      // DO NOT TOUCH THE OTHER FILE!
      // Do your code here!
      Account jensPalmborg = new Account("Poor as always", 100.00);
      jensPalmborg.Deposit(20);
      Console.WriteLine(jensPalmborg.balance);


    }
  }
}
