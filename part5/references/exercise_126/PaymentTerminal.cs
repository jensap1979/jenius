namespace exercise_126
{
  public class PaymentTerminal
  {
    public double money { get; private set; }  // amount of cash
    public int coffeeAmount { get; private set; } // number of sold coffees
    public int lunchAmount { get; private set; }  // number of sold lunches

    public PaymentTerminal()
    {
      // register initially has 1000 euros of money
      this.money = 1000;

    }

    public double DrinkCoffee(double payment)
    { 
        if (payment >= 2.50)

        {
      // an coffee now costs 2.50 euros
      // increase the amount of cash by the price of an coffee mean and return the change
      // if the payment parameter is not large enough, no coffee is sold and the method should return the whole payment

            this.money += 2.50;
            this.coffeeAmount++;
            return payment - 2.50;
        }
     return payment;
    }
    
    public double EatLunch(double payment)
    {
      if (payment >= 10.30)
      {
        // a lunch now costs 10.30 euros
        // increase the amount of cash by the price of a lunch and return the change
        // if the payment parameter is not large enough, no lunch is sold and the method should return the whole payment

          this.money += 10.30;
          this.lunchAmount++;
          return payment - 10.30;
          
          }
        return payment;
        }
        public bool DrinkCoffee(PaymentCard card)
        {
        
          if (card.balance >= 2.50)
          {
            card.TakeMoney(2.50);
            return true;
          }
        
      
        
          // a coffee costs 2.50 euros
          // if the payment card has enough money, the balance of the card is decreased by the price, and the method returns true
          // otherwise false is returned
          
          return false;
        }

        public bool EatLunch(PaymentCard card)
        {
        if (card.balance < 10.30)
        {
          card.TakeMoney(10.30);
          // a lunch costs 10.30 euros
          // if the payment card has enough money, the balance of the card is decreased by the price, and the method returns true
          // otherwise false is returned
          return true;
        }
        return false;
        }
        public void AddMoneyToCard(PaymentCard card, double sum)
        {
          // ...
          card.AddMoney(sum);
          this.money = this.money + sum;

        }

        public override string ToString()
        {
          return "money: " + money + ", number of sold coffees: " + coffeeAmount + ", number of sold lunches: " + lunchAmount;
        }
  }
}