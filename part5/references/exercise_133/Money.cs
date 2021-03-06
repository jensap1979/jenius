namespace exercise_133
{
  public class Money
  {

    private int euros;
    private int cents;

    public Money(int euros, int cents)
    {
      if (cents > 99)
      {
        euros = euros + cents / 100;
        cents = cents % 100;
      }

      this.euros = euros;
      this.cents = cents;
    }

    public Money Plus(Money addition)
    {
      int eurosAdded = this.euros + addition.euros;
      int centsAdded = this.cents + addition.cents;
      Money newMoney = new Money(eurosAdded, centsAdded);
      // create a new Money object that has the correct worth

      // return the new Money object
      return newMoney;
    }

    public Money Minus(Money decreaser)
    {
      Money newMoney = new Money (eurosAdded, centsAdded);
      // create a new Money object that has the correct worth

      // return the new Money object
      return newMoney;
    }

    public bool LessThan(Money compared)
    if( this.euros < compared.euros)
    {
      
      {// Do something here
      return true;
      } 
      else if (this.cents < compared.cents)
      {
          return true;
      }
      return false;
    }
  }
    public override string ToString()
    {
      string zero = "";
      if (cents < 10)
      {
        zero = "0";
      }

      return euros + "." + zero + cents + "e";
    }
  }
}
