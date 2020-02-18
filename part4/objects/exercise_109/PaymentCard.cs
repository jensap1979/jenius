namespace exercise_109
{
    public class PaymentCard
    {
        private double balance;

        public void AddMoney(double amount) 
        {
    // write code here
        
           
            if (amount > 0)
            {
                this.balance = this.balance + amount;
            }
            if (this.balance > 150)
            {
                this.balance = 150;
            }
        
        }
        
        public PaymentCard(double openingBalance)
        {
            // write code here
            this.balance = openingBalance - this.balance;
        }

       
        public void EatLunch()
        {
            double lunch = 10.60;
            this.balance = this.balance - lunch;
            if (this.balance > lunch)
            {
                this.balance = this.balance - lunch;
            }
        }

      
        public void DrinkCoffee()
        {
            double coffe = 2.0;
            this.balance = this.balance - coffe;
            if (this.balance > coffe)
            {
                this.balance = this.balance - coffe;
            }
            
            

        }

        public override string ToString()
        {
            // write code here
            return "The card has a balance of " + this.balance + " euros";

        }
        
    }
}