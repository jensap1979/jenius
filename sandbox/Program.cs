
using System;
namespace sandbox
{
  class Program
 {
 public static void Main(string[] args)
  { 
    string text = ("text.txt");

  // Display the file contents to the console. Variable text is a string.
   Console.WriteLine("This was done with ReadAllText.");
    Console.WriteLine(text);

  //Print empty line for easier reading
    Console.WriteLine();



  // Display the file contents by using a foreach loop.
  foreach (string line in lines)
    {
    Console.WriteLine(line);
    }
   
  }
}