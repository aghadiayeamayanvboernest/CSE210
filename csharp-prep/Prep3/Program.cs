using System;

class Program
{
    static void Main(string[] args)
    
    {
        // Initialize playAgain Variable to "yes to start the game 
        string playAgain = "yes";

        //this line of code is the outer loop to repeat the game as long as the user want to play again
        while (playAgain.ToLower() == "yes")
        {
            Console.WriteLine("Guess the magic number! It is between 1 and 204.");
            Console.WriteLine();
            
            //Console.Write("Enter the magic number: ");
            //string magicNumberInput = Console.ReadLine();
            //int magicNumber = int.Parse(magicNumberInput);

            // Randomly generate the magic number betwee 1 and 204
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 205);

            //Initialize guessMagicNumber to a value that is not equa to the magic number
            int guessMagicNumber = -1;

            int numberOfGuesses = 0;

            //This line of code keep asking for guesses untill the user guesses the magic number 
            while(guessMagicNumber != magicNumber)
            {
                // This line f Code Increment the number of guesses
                numberOfGuesses++;

                //This set of code prompt the user to guess the magic number
                Console.Write("Guess the magic number: ");
                string guessMagicnumberInput = Console.ReadLine();
                guessMagicNumber = int.Parse(guessMagicnumberInput);

                //This set of ode determine if the user guess is too high, too low, or correct
                if (guessMagicNumber > magicNumber)
                {
                    Console.WriteLine("You need to Aim Lower");
                }
                else if (guessMagicNumber < magicNumber)
                {
                    Console.WriteLine("You need to Aim Higher");
                }
                else 
                {
                    Console.WriteLine("That's it! You guessed the magic number!");
                }
            } 

            Console.WriteLine();
            // This line of Code Inform the User about the total Number of guesses they made 
            Console.WriteLine($"You made a total of {numberOfGuesses} guesses.");

            Console.WriteLine();
            // This line of code prompt the user if they want to play again
            Console.Write("Do you want to play again? (yes/no): ");
            playAgain = Console.ReadLine(); 
        }

    }
}    