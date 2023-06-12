using System;

class Program
{
    static void Main(string[] args)
    {
        Animal animal = new Dog ();
        animal.Move();

        Bird bird = new Bird();
        bird.Speak();
    }
}