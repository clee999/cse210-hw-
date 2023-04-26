using System;

class Program
{
    static void Main(string[] args)
    {
        {   
            // need to declare Variables before the while loop 
            int guess_attempted = 0;
            Console.Write("What is the magic number? ");
            int magic_number = int.Parse(Console.ReadLine());

            string response = "yes";
            int guess ;
            
            do {
                // this is where the loop starts and the user enter guess
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
                guess_attempted += 1;
             
                 //this If statement helps to reset the counter and arcs the user if they want to continue
                 if (guess == magic_number) {
                     Console.Write($"You've guessed it!, your total amount guesses are {guess_attempted}\n");
                     Console.Write("Would you like to continue? ");
                     response = Console.ReadLine();
                     Console.Write("What is the magic number? ");
                     magic_number = int.Parse(Console.ReadLine());
                     guess_attempted = 0;

                }
                else if (guess > magic_number) {
                        Console.Write("Lower\n");
                }
                    
                else if (guess < magic_number) {
                        Console.Write("Higer\n");
                }
                // This is the Criteria. 
             } while (guess != magic_number || response == "yes"); 
        }

    }
        
}
