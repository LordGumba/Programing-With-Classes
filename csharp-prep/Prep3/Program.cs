using System;

class Program
{
    static void Main(string[] args)
    {
                Console.WriteLine("Hello Prep3 World!");

        int guess = 0;
        Random randomGenerator = new Random();
        int random = randomGenerator.Next(1,100);
        do{
            Console.WriteLine("Whats the magic number? ");
            guess = int.Parse(Console.ReadLine());
            if (guess > random){
                Console.WriteLine("Too High!");
            }
            else if (guess < random) {
                Console.WriteLine("Too Low!");
            }
            else{
                Console.WriteLine("Thats it!");
            }
        } while (guess != random);
        
    }
}