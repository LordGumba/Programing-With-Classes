namespace FitnessTracker
{
    public class Running : Activity
    {
        public double Distance { get; set; }

        public override double GetDistance()
        {
            return Distance;
        }

        public override double GetSpeed()
        {
            return Distance / Length * 60;
        }

        public override double GetPace()
        {
            return Length / Distance;
        }
    }
}