using System;

class Program
{
    static void Main(string[] args)
    {
        Scripture scripture = new Scripture(
            "Trust in the LORD with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.",
            new Reference("Proverbs", 3, 5, 6));

        while (!scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            Console.Write("Press Enter to hide a word or type 'quit' to exit: ");
            string userInput = Console.ReadLine();
            if (userInput.ToLower() == "quit")
            {
                break;
            }
            scripture.HideRandomWords(2); // Hide 2 random words each time
        }
        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine("All words are hidden. Program will now exit.");
        Console.WriteLine();
    }
    
}

    
