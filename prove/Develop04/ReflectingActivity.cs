using System.Data.SqlTypes;

public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless." 
    };

    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?",
        "What challenges did you face during this experience?",
        "How did you overcome the obstacles you encountered?",
        "What skills did you use to navigate this situation?",
        "Who helped you during this experience and how?",
        "What emotions did you feel throughout this experience?",
        "What would you do differently if you encountered a similar situation again?",
        "How has this experience changed your perspective on similar situations?",
        "What advice would you give someone going through a similar experience?",
        "How did this experience impact your relationships with others?",
        "What was the most rewarding part of this experience?",
        "How did you stay motivated during this experience?",
        "What did you learn about your strengths and weaknesses?",
        "How did this experience help you grow personally or professionally?",
        "What was the most surprising aspect of this experience?",
        "How did this experience align with your values or beliefs?",
        "What feedback did you receive from others about your actions?",
        "How did you balance this experience with other responsibilities?",
        "What insights did you gain about the people involved in this experience?",
        "How did this experience contribute to your long-term goals?",
        "What would you say is the biggest takeaway from this experience?"
    };

    public ReflectingActivity() : base("Reflecting", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {

    }

    public override void Run()
    {
        DisplayStartingMessage();

        Random random = new Random();
        ShuffleList(_prompts, random);
        string prompt = _prompts[random.Next(_prompts.Count)];
        Console.WriteLine("Ponder the following prompt:");
        Console.WriteLine($"---{prompt}---");
        Console.WriteLine();
        Console.Write("Once you're prepared, hit Enter to move forward.");
        Console.ReadLine();
        ShowSpinner();
        Console.WriteLine();
        

        Console.WriteLine("Now ponder on each of the folowing question as they are related to this experience.");
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.Clear();

        int elapsed = 0;
        List<string> usedQuestions = new List<string>(_questions);
    while (elapsed < _duration)
        {
            if (usedQuestions.Count == 0)
            {
                usedQuestions = new List<string>(_questions); 
                ShuffleList(usedQuestions, random);
            }

            string question = usedQuestions[0];
            usedQuestions.RemoveAt(0);
            Console.Write($">{question}");
            ShowSpinner();
            elapsed += 3;
        }

        DisplayEndingingMessage();
    }
}