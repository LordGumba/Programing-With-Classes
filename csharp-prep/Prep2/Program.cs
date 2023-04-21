using System;

class Program
{
    static void Main(string[] args)
    {
        string letter = "F";
        Console.Write("What is your grade percentage? ");
        int grade = int.Parse(Console.ReadLine());

        if (grade >= 90)
        {
            Console.Write("You passed! Great Job! ");
            letter = "A";
        }
        else if (grade >= 80 && grade < 90)
        {
            Console.Write("Your hard work paid off, You passed!");
            letter = "B";
        }
        else if (grade >= 70 && grade < 80)
        {
            Console.Write("You Passed! But just barely.");
            letter = "C";
        }
        else if (grade >= 60 && grade < 70)
        {
            Console.Write("You failed.");
            letter = "D";
        }
        else
        {
            Console.Write("...I'm disapointed in you.");
            letter = "F";
        }
        
        Console.WriteLine($"You got a {letter}.");
        
    }
}