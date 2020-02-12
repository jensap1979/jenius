using System;
using System.Collections.Generic;

namespace exercise_72
{
  class Program
  {
    public static void Main(string[] args)
    {
         //////////ask while
         ///ny kolumn int smallest
         //go through list  save numer aS int number if number is smaller than smaLLest 
         //smallest = number;
         //for (int i = 0; number in list --if list[i] == smallest)
         //writeline found at index +i;   
       List<int> list = new List<int>();
            while (true)
            {
                int input = Convert.ToInt32(Console.ReadLine());
                if (input == 9999)
                {
                    break;
                }
                list.Add(input);
            }

            int smallest = list[0];

            for (int index = 0; index < list.Count; index++)
            {
                if (smallest > list[index])
                {
                    smallest = list[index];
                }
            }
            Console.WriteLine("Smallest number: " + smallest);

            for (int index = 0; index < list.Count; index++)
            {
                if (list[index] == smallest)
                {
                    Console.WriteLine("Found at index: " + index);
                }
            }   
    }
  }
}
