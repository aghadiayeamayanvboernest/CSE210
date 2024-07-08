using System;
using System.Collections.Generic;
using System.Threading; 

class Program
{
    //I added a VisualActivity to include visual meditation techniques, enhancing user engagement. Furthermore, I ensured each session uses unique prompts and questions, avoiding repetition and providing fresh content for effective mindfulness practice. These changes aim to improve user experience by making relaxation and reflection more accessible.
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Choose an Activity:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Visualization Activity");
            Console.WriteLine("5. Exit"); 
            Console.Write("Enter Your Choice: ");
            string Choice = Console.ReadLine();
            Console.Clear();

            Activity activity = null;
            switch(Choice)
            {
                case "1":
                    activity = new BreathingActivity();
                    break;
                case "2":
                    activity = new ReflectingActivity();
                    break;
                case "3":
                    activity = new ListingActivity();
                    break;
                case "4":
                    activity = new VisualizationActivity();
                    break;
                case "5":     
                    Console.WriteLine("Exiting program ");
                    return;
                default:
                    Console.WriteLine("Invalid choice. please try again. ");
                continue;                   
            }

            activity.Run();
        }
    }
}