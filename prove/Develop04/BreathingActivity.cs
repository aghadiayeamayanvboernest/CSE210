using System.Runtime.InteropServices;
using System.Timers;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {

    }

    public override void Run()
    {
        DisplayStartingMessage();

        int elapsed = 0;
        while (elapsed < _duration)
        {
            
            Console.Write("Breathe in... ");
            ShowCountDown(5);
            elapsed += 5;
           
           Console.WriteLine(); 

            Console.Write("Now breathe out... ");
            ShowCountDown(5);
            elapsed += 5;

            Console.WriteLine();
            Console.WriteLine();
            
        }

        DisplayEndingingMessage();
    }
}