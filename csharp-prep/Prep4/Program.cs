using System;

class Program
{
    static void Main(string[] args)
    {
        int number = -1;
        List<int> numbers = new List<int>();
        do{
            Console.WriteLine("Enter the numbers, enter zero when complete.");
            number = int.Parse(Console.ReadLine());

            numbers.Add(number);
        } while (number != 0);
        int sum = 0;
        int max = 0;
        for (int i = 0; i < numbers.Count; i++)
{
    sum = (numbers[i]) + sum;
    if (max < number){
        max = number;
    }
    else{
        max += 0;
    }
}
    
float average = sum / (numbers.Count - 1);
Console.WriteLine($"The sum is {sum}");
 Console.WriteLine($"The Average is {average}");
Console.WriteLine($"The Maximun is {max}");

    }
}