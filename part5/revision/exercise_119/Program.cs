using System;
using System.IO;


namespace exercise_119
{
  class Program
  {
    static void Main(string[] args)
    {
      ClockHand hours = new ClockHand(24);
      ClockHand minutes = new ClockHand(60);
      ClockHand seconds = new ClockHand(60);

      while (true)
      {
        // 1. Printing the time
        Console.WriteLine(hours + ":" + minutes + ":" + seconds);

        // 2. Advancing the second hand
        seconds.Advance();

       
          }
      }
    }
  }
}