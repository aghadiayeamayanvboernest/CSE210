public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {

    }
    public override void Run()
    {
        DisplayStartingMessage();

        Random random = new Random();
        ShuffleList(_prompts, random);
        string prompt = _prompts[random.Next(_prompts.Count)];
        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine($"---{prompt}---");
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.WriteLine();

        int elapsed = 0;
        List<string> responses = new List<string>();
        while(elapsed < _duration)
        {
            Console.Write("> ");
            string response = Console.ReadLine();
            responses.Add(response);
            elapsed += 3;
        }

        Console.WriteLine($"You listed {responses.Count} items.");

        DisplayEndingingMessage();

    }
}