using System;

class Program
{
    static void Main(string[] args)
    {
       //Ouput asking the user for there name 
       Console.Write("What is your first name? ");
       //input reads and stores value in the string varible
       string fname = Console.ReadLine();

       Console.Write("What is your last name? ");
       string lname = Console.ReadLine();

       Console.WriteLine($"Your name is {lname}, {fname} {lname}.");



    }
}