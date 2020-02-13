
using System;
using System.IO;

class Text;
{
 private static void Main()
   { 
  string text = File.ReadAllText("text.txt");

  // Display the file contents to the console. Variable text is a string.
  Console.WriteLine("This was done with ReadAllText.");
  Console.WriteLine(text);

  //Print empty line for easier reading
  Console.WriteLine();

  // Example #2
  // Read each line of the file into a string array. 
  //Each element of the array is one line of the file.
  Console.WriteLine("This was done with ReadAllLines.");
  string[] lines = File.ReadAllLines("text.txt");

  // Display the file contents by using a foreach loop.
  foreach (string line in lines)
  {
    Console.WriteLine(line);
  }
}