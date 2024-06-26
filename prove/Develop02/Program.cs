using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Your Journal!");

        PromptGenerator promptGenerator = new PromptGenerator();
        Journal journal = new Journal();

        while (true)
        {
            Console.WriteLine("\nJournal Menu: ");
            Console.WriteLine("1. Write a new Entry");
            Console.WriteLine("2. Display the journal entries");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Exit");

            Console.Write("Enter your choice: ");
            int choice;
            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Invalid choice. Please enter a number.");
                continue;
            }

            switch (choice)
            {
                case 1:
                    string prompt = promptGenerator.GetPrompt();
                    Console.WriteLine($"\nPrompt: {prompt}");
                    Console.Write("Your response: ");
                    string response = Console.ReadLine();

                    Console.Write("Enter your mood: ");
                    string mood = Console.ReadLine();

                    Console.Write("Enter the weather: ");
                    string weather = Console.ReadLine();

                    Console.Write("Enter your location: ");
                    string location = Console.ReadLine();

                    Entry entry = new Entry(response, prompt, mood, weather, location);
                    journal.AddEntry(entry);
                    Console.WriteLine("Entry added successfully!");
                    break;

                case 2:
                    Console.WriteLine("\n--- Journal Entries ---");
                    journal.DisplayEntries();
                    break;

                case 3:
                    Console.Write("\nEnter a filename to save the journal: ");
                    string saveFilename = Console.ReadLine().Trim();
                    journal.SaveJournal(saveFilename);
                    break;

                case 4:
                    Console.Write("\nEnter a filename to load the journal: ");
                    string loadFilename = Console.ReadLine().Trim();
                    journal.LoadJournal(loadFilename);
                    break;

                case 5:
                    Console.WriteLine("Exiting...");
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please enter a number between 1 and 5.");
                    break;
            }
        }
    }
}
