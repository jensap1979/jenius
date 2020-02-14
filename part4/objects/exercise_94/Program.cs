using System;

namespace exercise_94
{
  class Program
  {
    public static void Main(string[] args)
    {
      // DO NOT TOUCH THE OTHER FILE!
      // Do your code here!
      Account Heikki = new Account("Heikki's account", 1000);
      Account Personal = new Account("Personal account", 0);

      Heikki.Withdrawal(100);
      Personal.Deposit(100);
      
      Console.WriteLine(Heikki);
      Console.WriteLine(Personal);
    }
  }
}



