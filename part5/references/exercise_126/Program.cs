using System;
using System.Collections.Generic;

namespace exercise_126
{
  class Program
  {
    public static void Main(string[] args)
    {
      PaymentCard petesCard = new PaymentCard(10);

      Console.WriteLine("money " + petesCard.balance);
      bool wasSuccessful = petesCard.TakeMoney(8);
      Console.WriteLine("successfully withdrew: " + wasSuccessful);
      Console.WriteLine("money " + petesCard.balance);

      wasSuccessful = petesCard.TakeMoney(4);
      Console.WriteLine("successfully withdrew: " + wasSuccessful);
      Console.WriteLine("money " + petesCard.balance);

    }
  }
}
