using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    //"In my program, I added a creative touch by enabling scripture loading from a file. This feature allows users to seamlessly engage with different texts, enhancing flexibility without requiring any code changes. It's a user-friendly design that keeps data separate from operations, making updates and maintenance straightforward.
    static void Main(string[] args)
    {
        // Load scriptures from file
        string filePath = "Scriptures.txt";
        List<Scripture> scriptures = LoadScripturesFromFile(filePath);

        // this line of code Ensure there are scriptures loaded
        if (scriptures.Count == 0)
        {
            Console.WriteLine("No scriptures loaded from the file.");
            return;
        }

        // Create a random number generator
        Random random = new Random();

        // Pick a random index
        int randomIndex = random.Next(scriptures.Count);
        Scripture selectedScripture = scriptures[randomIndex];

        while (!selectedScripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(selectedScripture.GetDisplayText());
            Console.WriteLine();
            Console.Write("Press Enter to hide a word or type 'quit' to exit: ");
            string userInput = Console.ReadLine();
            if (userInput.ToLower() == "quit")
            {
                break;
            }
            selectedScripture.HideRandomWords(2); // Hide 2 random words each time
        }

        Console.Clear();
        Console.WriteLine(selectedScripture.GetDisplayText());
        Console.WriteLine("All words are hidden. Program will now exit.");
        Console.WriteLine();
    }

    static List<Scripture> LoadScripturesFromFile(string filePath)
    {
        var scriptures = new List<Scripture>();

        try
        {
            var lines = File.ReadAllLines(filePath);

            foreach (var line in lines)
            {
                // Skip empty or whitespace lines
                if (string.IsNullOrWhiteSpace(line))
                {
                    continue;
                }

                var parts = line.Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
                if (parts.Length == 2)
                {
                    var text = parts[0].Trim();
                    var referenceParts = parts[1].Trim().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    if (referenceParts.Length == 4)
                    {
                        string book = referenceParts[0];
                        if (int.TryParse(referenceParts[1], out int chapter) &&
                            int.TryParse(referenceParts[2], out int verseStart) &&
                            int.TryParse(referenceParts[3], out int verseEnd))
                        {
                            var reference = new Reference(book, chapter, verseStart, verseEnd);
                            var scripture = new Scripture(text, reference);
                            scriptures.Add(scripture);
                        }
                        else
                        {
                            Console.WriteLine($"Error parsing reference parts: {string.Join(" ", referenceParts)}");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Error splitting reference: {parts[1].Trim()}");
                    }
                }
                else
                {
                    Console.WriteLine($"Error splitting line: {line}");
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error reading file: {ex.Message}");
        }

        return scriptures;
    }
}

