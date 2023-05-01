using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayMessage("Welcome to the program!");

        Console.Write("Are you a Brother or Sister? ");
        string title = Console.ReadLine();
        PromptBro_Sis(title);

        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        PromptUserName(name);

        Console.Write("Please enter your favorite number: ");
        int fav_num = int.Parse(Console.ReadLine());
        PromptUserNumber(fav_num);
        double sq_root = SquareNumber(fav_num);
        DisplayResult(name, sq_root, title);


    }
    static void DisplayMessage(string message)
    {
        
    }

    static void PromptBro_Sis(string title)
    {

    }

    static void PromptUserName(string name)
    {
       
    }

    static void PromptUserNumber(int fav_num)
    {
        
    }

    static double SquareNumber(double fav_num)
    {
        double sq_root = Math.Sqrt(fav_num);
        return sq_root;
    
    }

    static void DisplayResult(string name, double sq_root, string title)
    {
        Console.WriteLine($"{title} {name}, the square root of your number is {Math.Round(sq_root, 2)}.");
    }
        
    
}







