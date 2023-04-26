using System;

class Program
{
    static void Main(string[] args)
    {
        List<int>numbers =  new List<int>();
        int sum;
        Double average;
        int largest;
        Console.WriteLine("Enter a list of numbers, type 0 when finished");
        int number;
    do {
        Console.WriteLine("Enter a number:"); 
        number = int.Parse(Console.ReadLine());
        numbers.Add(number);
        sum = numbers.Sum();
        average = numbers.Average();
        largest = numbers.Max();

        } while(number != 0);

        Console.WriteLine($"The sum is {sum}.");
        Console.WriteLine($"The average is {average}.");
        Console.WriteLine($"The Largest number is {largest}.");


    }



}