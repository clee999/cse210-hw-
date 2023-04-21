using System;

class Program
{
    static void Main(string[] args)
    {

          //Ouput asking the user for there name 
       Console.Write("Enter your grade: ");
       //input reads and stores value in the string varible
       string grade = Console.ReadLine();
       int number = int.Parse(grade);

        if ( number >= 90 ){

            Console.Write("You grade is A ");
        }
        else if (number >= 80 ) {

            Console.Write("You grade is B ");

        }

        else {

            Console.Write("You grade is D ");

        }
    }
}