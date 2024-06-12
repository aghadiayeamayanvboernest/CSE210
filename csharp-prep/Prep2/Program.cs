using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please enter your grade percentage: ");
        string inputAnswer = Console.ReadLine();
        int gradePercent = int.Parse(inputAnswer);

        string letter = "";
        string sign = "";
        // This set of code Determine the letter grade 
        if (gradePercent >= 90)
        {
            letter = "A";
        }
        else if (gradePercent >= 80)
        {
            letter = "B";
        }
        else if (gradePercent >= 70)
        {
            letter = "C";
        }
        else if (gradePercent >= 60)
        {
            letter = "D";
        }
        else 
        {
            letter = "F";
        }

        // This set of code Determine the grade sign for all letter except F

        if (letter != "F")
        {
            int lastDigit = gradePercent % 10;

            if (lastDigit >= 7)
            {
                sign = "+";
            }
            else if (lastDigit < 3)
            {
                sign ="-";
            }   
        }

        // This set of code handle the special case for A grades 
        if(letter == "A" && sign == "+")
        {
            sign = ""; // Set sign to empty to remove the "+"
        }


        Console.WriteLine($"Your grade is: {letter}{sign}");

        if (gradePercent >= 70)
        {
            Console.WriteLine("Excellent work, you have passed the course.");
        }
        else
        {
            Console.WriteLine("Keep trying, you'll get it next time.");
        }


    }
}