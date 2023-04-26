using System;

class Program
{
    

    static void Main(string[] args)
    {
        DisplayMessage();

        string userName = DisplayPersonaluserName();
        int userNumber = PersonalUserNumber();

        int squaredNumber = SquareNumbers(userNumber);

        DisplayResult(userName, squaredNumber);
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
   static void DisplayPersonaluserName(string userName)
{
    Console.WriteLine($"Hello {userName}");
}

   static void PersonalUserNumber(string userNumber)
{
    Console.WriteLine($"Oh! your favorite number is {userNumber}!");
}
    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }
}