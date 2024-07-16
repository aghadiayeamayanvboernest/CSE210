using System;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;

/*
  my creaivity in my program is async follows:
  1. Negative Goals: Introduced the concept of negative goals where users can track and manage bad habits. 
     When a negative goal event is recorded, it subtracts points from the user's score, serving as a penalty 
     for engaging in undesirable behavior. This helps users become more aware of their habits and encourages 
     them to avoid negative actions.
  
  2. Progress Goals: Added progress goals to allow users to track their progress towards larger goals that 
     require incremental achievements. Users can record events to increment progress, and upon reaching 
     the target progress, the goal is marked as complete. This feature is particularly useful for tracking 
     long-term goals such as training for a marathon or completing a complex project.
  
  These additions enhance the GoalManager program by providing a more comprehensive goal-tracking system that 
  not only rewards positive behaviors but also addresses negative habits and supports long-term goal achievements.
 */
 class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        manager.ShowMenu();
    }
}