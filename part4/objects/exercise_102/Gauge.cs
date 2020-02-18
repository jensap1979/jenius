using System;

namespace exercise_102
{
    public class Gauge
    {
        public int value { get; set; }
        public Gauge()
        {
            this.value = 0;
        }
        public void Increase()
        {
            
            if (this.value < 5)
            {
                this.value++;
            }
        }
        
        public void Decrease()
        {
            if (this.value > 1)
            {
                this.value--;
            }
        }
       
        public bool Full()
        {
            return this.value == 5;
        }
    }
}