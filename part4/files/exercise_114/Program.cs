using System;

namespace exercise_114
{
    class Program
    {
        public static void Main(string[] args)
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>();

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
        }
    }
}
