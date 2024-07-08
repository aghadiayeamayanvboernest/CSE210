using System.ComponentModel;

public abstract class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string discription)
    {
        _name = name;
        _description = discription;
    }

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcom to the {_name} Activity.");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.Write("For how many seconds would you like this session to last? ");
        _duration = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Prepare to begin...");
        ShowSpinner();
        
    }
    public void DisplayEndingingMessage()
    {
        Console.WriteLine();
        Console.WriteLine("WellDone!");
        ShowSpinner();
        Console.WriteLine($"Great job! You have completed the {_name} activity for {_duration} sencods. ");
        ShowSpinner();
    }

    public void ShowSpinner()
    {
        List<string>spinner = new List<string>();
        spinner.Add("|");
        spinner.Add("/");
        spinner.Add("-");
        spinner.Add("\\");
        spinner.Add("|");
        spinner.Add("/");
        spinner.Add("-");
        spinner.Add("\\");
    
        foreach (string s in spinner)
        {
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.WriteLine();
    }

    public void ShowCountDown(int seconds)
    {
        for(int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        
        }
    }
    protected void ShuffleList<T>(List<T> list, Random random)
    {
        for (int i = list.Count - 1; i > 0; i--)
        {
            int j = random.Next(i + 1);
            T temp = list[i];
            list[i] = list[j];
            list[j] = temp;
        }
    }
    public abstract void Run();
}