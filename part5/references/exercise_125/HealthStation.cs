namespace exercise_125
{
  public class HealthStation
  {
    public int weighings { get; private set; }

    // Create a constructor here, if needed
   
    public int Weigh(Person person)
    {
      // return the weight of the person passed as the parameter
      // incrase weighings
      this.weighings++;
      return person.weight;
    }

    public void Feed(Person person)
    {
      // Increse the weight of the person with one kilogram
<<<<<<< HEAD
      person.weight++;
    
=======
    person.weight = person.weight +1;
>>>>>>> 630d9ad598717df5d4c9c0638f077767bcf5a587
    }
  }
}