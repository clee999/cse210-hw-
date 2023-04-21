using System;

class Program
{
    static void Main(string[] args)
    {

          //Ouput asking the user for there name 
       Console.Write("Enter your percentage: ");
       //input reads and stores value in the string varible
       
       int grade = int.Parse(Console.ReadLine());

       string letter = "";
       int lastdigit = grade % 10;

        if ( grade >= 90 )
        {
            letter = "A";
        }
        else if (grade >= 80 ) 
        {
            letter = "B";  
        }

        else if (grade >= 70 ) 
        {
            letter = "C";  
        }

        else if (grade >= 60 ) 
        {
            letter = "D";
        }
        else 
        {
            letter = "F";
        }

        if (lastdigit >= 3 && lastdigit <= 6) 
        {
            letter += "-";

               if (letter == "F-")
               {
                 letter = "F";
               }
          }
        else if (lastdigit >= 7)
        {
            letter += "+";
               if (letter == "F+")
               {
                letter = "F";
               }
               
          }

        Console.Write($"Your grade is: {letter}. ");

        if (grade >= 70)
        {
            Console.Write("Congrats, you've passed.");
        }
        else 
        {
             Console.Write("Unfortunately, you've Failed. Please try again.");
        } 
    }
}