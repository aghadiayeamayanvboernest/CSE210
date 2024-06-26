public class Entry
{
    private string _entryText;
    private DateTime _entryDate;
    private string _prompt;
    private string _mood; // New field for mood
    private string _weather; // New field for weather
    private string _location; // New field for location

    public Entry(string entryText, string prompt, string mood, string weather, string location)
    {
        _entryText = entryText;
        _entryDate = DateTime.Now;
        _prompt = prompt;
        _mood = mood;
        _weather = weather;
        _location = location;
    }

    public void DisplayEntry()
    {
        Console.WriteLine($"Date: {_entryDate} - Prompt: {_prompt}");
        Console.WriteLine($"Mood: {_mood}, Weather: {_weather}, Location: {_location}");
        Console.WriteLine($"{_entryText}");
    }

    public string Response() => _entryText;
    public DateTime Date() => _entryDate;
    public string Prompt() => _prompt;
    public string Mood() => _mood; // Getter for mood
    public string Weather() => _weather; // Getter for weather
    public string Location() => _location; // Getter for location
}

    