using System;

class Program
{
    

    static void Main(string[] args)
    {
        DisplayMessage();
        
        Console.WriteLine("Whats your username?");
        string name = Console.ReadLine();

        Console.WriteLine("Whats your usernumber?");
        int number = int.Parse(Console.ReadLine());

        DisplayPersonalUserName(name);
        PersonalUserNumber(number);

       

        int squaredNumber = SquareNumbers(number);

        DisplayResult(name, squaredNumber);
    }
    static int SquareNumbers(int first)
{
    int square = first * first;
    return square;
}
    static void DisplayMessage()
{
    Console.WriteLine("Hello world!");
}
   static void DisplayPersonalUserName(string userName)
{
    Console.WriteLine($"Hello {userName}");
}

   static void PersonalUserNumber(int userNumber)
{
    Console.WriteLine($"Oh! your favorite number is {userNumber}!");
}
    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }
}