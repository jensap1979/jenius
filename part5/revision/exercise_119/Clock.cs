namespace exercise_119
{
    public class Clock
    {
    public ClockHand hours;
    public ClockHand minutes;
    public ClockHand seconds;

    public Clock()
        {
            this.hours = new ClockHand(24);
            this.minutes = new ClockHand(60);
            this.seconds = new ClockHand(60);
        }

        public void Advance()
        {
            this.seconds.Advance();

            if (this.seconds.value == 0)
            {
            this.minutes.Advance();

            if (this.minutes.value == 0)
            {
                this.hours.Advance();
            }
            }
        }

        public override string ToString()
        {
            return hours + ":" + minutes + ":" + seconds;
        }
    }
}