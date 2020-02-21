namespace exercise_109
{
    public class PaymentCard
    {
        private double balance;

        public PaymentCard(double openingBalance)
        {
            // write code here
            this.balance = openingBalance;
        }

        
        public void EatLunch()
        {
            double lunch = 10.60;
            if (this.balance > lunch)
            {
                this.balance = this.balance - lunch;
            }
        }

       
        public void DrinkCoffee()
        {
            double coffe = 2.0;
            if (this.balance > coffe)
            {
                this.balance = this.balance - coffe;
            }
        }

        
        public void AddMoney(double amount)
        {
            //write code here
            if (amount > 0)
            {
                this.balance = this.balance + amount;
            }
            if (this.balance > 150)
            {
                this.balance = 150;
            }
        }

        public override string ToString()
        {
            // write code here
            return "The card has a balance of " + this.balance + " euros";
        }
    }
}