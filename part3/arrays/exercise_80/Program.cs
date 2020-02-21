using System;
using System.Collections.Generic;

namespace exercise_80
{
  class Program
  {
    public static void Main(string[] args)
    {
      string[] allIn = new string[5];
      int[] numbers = { 5, 1, 3, 4, 1 };
      int sum = SumOfNumbersInArray(numbers);
      Console.WriteLine(sum);

    } /////ok

        public static int SumOfNumbersInArray(int[] numbers)
        {
            int sumOfArray = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sumOfArray += numbers[i];
            }
            return sumOfArray;
        }
      
    
  }
}



