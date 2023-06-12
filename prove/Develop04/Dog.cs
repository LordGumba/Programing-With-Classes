public class Dog : Animal
{
    private string _sound = "woof";

    public Dog()
    {
        base._legs = 4;
    }

    public void Speak()
    {
        
        base.Move();
        System.Console.WriteLine($"{_sound}, {_sound}");
    }
}