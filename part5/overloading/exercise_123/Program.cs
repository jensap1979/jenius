using System;

namespace exercise_123
{
  class Program
  {
    public static void Main(string[] args)
    {
      // You can test your code here.
    Counter counter = new Counter();
   
    counter.Increase();
    counter.Increase();
    counter.Increase();

    Console.WriteLine(counter.value);

    counter.Increase(2);

    Console.WriteLine(counter.value);

    counter.Decrease(2);
    counter.Decrease(2);
    counter.Decrease(1);
     
    Console.WriteLine(counter.value);
     

    

    }
  }
}
