
//My creativity for this code was to enhance the journaling experience by allowing users 
//to input additional contextual information such as mood, weather, and location with each journal entry. This ensures that each entry 
//is more detailed and meaningful, providing a richer record of the user's experiences.
using System;
using System.IO;
using System.Collections.Generic;


public class Journal
{
    private List<Entry> _entryList = new List<Entry>();
    private string _journalFilename = "journal.json";

    // Method to save journal entries to a file with additional information
    public void SaveJournal(string _journalFilename)
    {
        using (StreamWriter writer = new StreamWriter(_journalFilename))
        {
            foreach (var entry in _entryList)
            {
                string line = $"{entry.Date()}|{entry.Prompt()}|{entry.Response()}|{entry.Mood()}|{entry.Weather()}|{entry.Location()}";
                writer.WriteLine(line);
            }
        }
        Console.WriteLine("Journal saved successfully!");
    }

    // Method to load journal entries from a file with additional information
    public void LoadJournal(string _journalFilename)
    {
        _entryList.Clear();
        if (File.Exists(_journalFilename))
        {
            using (StreamReader reader = new StreamReader(_journalFilename))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    string[] parts = line.Split('|');
                    if (parts.Length == 6)
                    {
                        string date = parts[0].Trim();
                        string prompt = parts[1].Trim();
                        string entryText = parts[2].Trim();
                        string mood = parts[3].Trim();
                        string weather = parts[4].Trim();
                        string location = parts[5].Trim();
                        Entry loadedEntry = new Entry(entryText, prompt, mood, weather, location);
                        _entryList.Add(loadedEntry);
                    }
                }
            }
            Console.WriteLine("Journal loaded successfully");
        }
        else
        {
            Console.WriteLine("Journal File does not exist.");
        }
    }

    public void AddEntry(Entry entry)
    {
        _entryList.Add(entry);
    }

    public void DisplayEntries()
    {
        foreach (var entry in _entryList)
        {
            entry.DisplayEntry();
            Console.WriteLine();
        }
    }

    public List<Entry> GetEntryList()
    {
        return _entryList;
    }
}
