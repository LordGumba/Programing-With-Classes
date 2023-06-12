public class Animal
{
    private int _legs = 3;
    public Animal ()
    {

    }
    public void Move()
    {
        System.Console.WriteLine($"I'm moving on {_legs} legs!");
    }
    public void SetLegs(int legs)
    {
        if (legs > 4)
        {
            throw new ArgumentException("Animals cant have more than 4 legs");
        }
    }
}