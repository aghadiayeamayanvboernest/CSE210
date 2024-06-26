public class PromptGenerator
{
    private List<string>_promptList = new List<string>
    {
        "What are three things I am grateful for today?",
        "What was the most significant lesson i learend today?",
        "Describe a moment today when you felt truly at peace.",
        "What challenges did i face and how did I overcome them?",
        "What is one thing I could improve on from today?",
        "Who made a positive impact on my day and why?",
        "what was the most surprising thing that happened today?",
        "How did I practice self-care today?",
        "How did I practices self-control today",
        "Describe a moment of kindness you experienced or witnessed today.",
        "What are my goals for tomorrow?"
    };

    public string GetPrompt()
    {
        Random random = new Random();
        int index = random.Next(_promptList.Count);
        return _promptList[index];
    }    
}


