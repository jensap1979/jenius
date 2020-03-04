using System;

namespace exercise_114
{
    class Program
    {
        public static void Main(string[] args)
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>();

<<<<<<< HEAD
            // a person object can be created first
            Person john = new Person("John");
            // and then added to the list
            persons.Add(john);

            // person objects can also be created "in the same sentence" that they are added to the list
            persons.Add(new Person("Matthew"));
            persons.Add(new Person("Martin"));

            foreach (Person person in persons)
            {
                Console.WriteLine(person);
            }
=======
          // start counter
          int counter = 0;
            while (true)
            {
                string line = Console.ReadLine();

                if (line == "end")
                {
                    break;
                }
                counter++;
            }
            // print number of lines
            Console.WriteLine(counter);
>>>>>>> 630d9ad598717df5d4c9c0638f077767bcf5a587
        }
    }
}
