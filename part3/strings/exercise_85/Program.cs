using System;
using System.Collections.Generic;

namespace exercise_85
{
  class Program
  {
    public static void Main(string[] args)
    {
<<<<<<< HEAD
      string username1 = "Emma";
      string username2 = "Alex";
      string username = Console.ReadLine();
      Console.WriteLine("Enter username: ");
      
      

      if (string = username1)
      {Console.WriteLine("Enter password: ")};
      if (string = username2)
      {Console.WriteLine("Enter password: ")};    
      
      
=======
      Console.WriteLine("Enter username:");
      string userName = Console.ReadLine();
      Console.WriteLine("Enter password:");
      string passWord = Console.ReadLine();
>>>>>>> 12f7d0dc74a364abb32957b339968b1706e10b4b

      if (userName == "emma" && passWord == "sunshine")
      {
        Console.WriteLine("You have successfully logged in!");
      }
      else if (userName == "alex" && passWord == "haskell")
      {
        Console.WriteLine("You have successfully logged in!");
      }
      else
      {
        Console.WriteLine("Incorrect username or password!");
      }

    }
  }
}

