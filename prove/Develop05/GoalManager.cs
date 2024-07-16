public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    private void DisplayPlayerInfo()
    {
        Console.WriteLine($"Score: {_score}");
    }

    public void ShowMenu()
    {
        while (true)
        {
            DisplayPlayerInfo();
            Console.WriteLine();
            Console.WriteLine("1. Create Goal");
            Console.WriteLine("2. Record Event");
            Console.WriteLine("3. List Goals");
            Console.WriteLine("4. Save Goals");
            Console.WriteLine("5. Load Goals");
            Console.WriteLine("6. Exit");
            Console.Write("Choose an option: ");
            int choice = int.Parse(Console.ReadLine());
            Console.WriteLine();

            switch (choice)
            {
                case 1:
                    CreateGoal();
                    break;
                case 2:
                    RecordEvent();
                    break;
                case 3:
                    ListGoalDetails();
                    break;
                case 4:
                    SaveGoals();
                    break;
                case 5:
                    LoadGoals();
                    break;
                case 6:
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    private void CreateGoal()
    {
        Console.WriteLine("Enter goal type:");
        Console.WriteLine("1. Simple");
        Console.WriteLine("2. Eternal");
        Console.WriteLine("3. CheckList");
        Console.WriteLine("4. Progress");
        Console.WriteLine("5. Negative");
        string choice = Console.ReadLine();

        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();

        Console.Write("Enter goal description: ");
        string description = Console.ReadLine();

        Console.Write("Enter goal points: ");
        int points = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case "1":
                _goals.Add(new SimpleGoal(name, description, points));
                break;
            case "2":
                _goals.Add(new EternalGoal(name, description, points));
                break;
            case "3":
                Console.Write("Enter target times to complete: ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("Enter bonus points: ");
                int bonus = int.Parse(Console.ReadLine());
                _goals.Add(new CheckListGoal(name, description, points, target, bonus));
                break;
            case "4":
                Console.Write("Enter target progress: ");
                int targetProgress = int.Parse(Console.ReadLine());
                _goals.Add(new ProgressGoal(name, description, points, targetProgress));
                break;
            case "5":
                Console.Write("Enter penalty points: ");
                int penaltyPoints = int.Parse(Console.ReadLine());
                _goals.Add(new NegativeGoal(name, description, points, penaltyPoints));
                break;
            default:
                Console.WriteLine("Invalid choice.");
                break;
        }
    }

    private void RecordEvent()
    {
        Console.WriteLine("Select a goal to record an event:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].ShortName}");
        }

        int choice = int.Parse(Console.ReadLine()) - 1;
        if (choice >= 0 && choice < _goals.Count)
        {
            _goals[choice].RecordEvent();
            int pointsEarned = _goals[choice].Points;
            _score += pointsEarned;

            Console.WriteLine($"Congratulations! You earned {pointsEarned} points.");

            // Check if the goal is a CheckListGoal and add bonus points if completed
            if (_goals[choice] is CheckListGoal checklistGoal && checklistGoal.IsComplete())
            {
                int bonusPoints = checklistGoal.GetBonusPoints();
                _score += bonusPoints;
                Console.WriteLine($"Congratulations! You earned a bonus of {bonusPoints} points for completing goal '{_goals[choice].Name}'!");
            }
            // Handle ProgressGoal specific behavior
            else if (_goals[choice] is ProgressGoal progressGoal && progressGoal.IsComplete())
            {
                Console.WriteLine($"Congratulations! You completed the progress goal '{_goals[choice].Name}'!");
            }
            // Handle NegativeGoal specific behavior
            else if (_goals[choice] is NegativeGoal negativeGoal)
            {
                int penaltyPoints = negativeGoal.penaltyPoints;
                _score -= penaltyPoints;
                Console.WriteLine($"You incurred a penalty of {penaltyPoints} points for goal '{_goals[choice].Name}'.");
            }
        }
        else
        {
            Console.WriteLine("Invalid choice. Please try again.");
        }
    }

    private void ListGoalDetails()
    {
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }

    private void SaveGoals()
    {
        Console.Write("Enter the filename to save goals: ");
        string filename = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter(filename))
        {
            writer.WriteLine(_score);
            foreach (var goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }

        Console.WriteLine("Goals saved successfully.");
    }

    private void LoadGoals()
    {
        Console.Write("Enter the filename to load goals: ");
        string filename = Console.ReadLine();

        if (File.Exists(filename))
        {
            using (StreamReader reader = new StreamReader(filename))
            {
                _score = int.Parse(reader.ReadLine());
                _goals.Clear();

                while (!reader.EndOfStream)
                {
                    string[] parts = reader.ReadLine().Split('|');
                    string type = parts[0];
                    string name = parts[1];
                    string description = parts[2];
                    int points = int.Parse(parts[3]);

                    switch (type)
                    {
                        case "SimpleGoal":
                            bool isComplete = bool.Parse(parts[4]);
                            var simpleGoal = new SimpleGoal(name, description, points);
                            simpleGoal.GetType().GetField("_isComplete", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance).SetValue(simpleGoal, isComplete);
                            _goals.Add(simpleGoal);
                            break;
                        case "EternalGoal":
                            _goals.Add(new EternalGoal(name, description, points));
                            break;
                        case "CheckListGoal":
                            int amountCompleted = int.Parse(parts[4]);
                            int target = int.Parse(parts[5]);
                            int bonus = int.Parse(parts[6]);
                            var checkListGoal = new CheckListGoal(name, description, points, target, bonus);
                            checkListGoal.GetType().GetField("_amountCompleted", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance).SetValue(checkListGoal, amountCompleted);
                            _goals.Add(checkListGoal);
                            break;
                        case "ProgressGoal":
                            int currentProgress = int.Parse(parts[4]);
                            int targetProgress = int.Parse(parts[5]);
                            var progressGoal = new ProgressGoal(name, description, points, targetProgress);
                            typeof(ProgressGoal).GetField("_currentProgress", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance).SetValue(progressGoal, currentProgress);
                            _goals.Add(progressGoal);
                            break;
                        case "NegativeGoal":
                            int penaltyPoints = int.Parse(parts[4]);
                            var negativeGoal = new NegativeGoal(name, description, points, penaltyPoints);
                            _goals.Add(negativeGoal);
                            break;
                        default:
                            Console.WriteLine($"Unknown goal type '{type}'. Skipping...");
                            break;
                    }
                }
            }

            Console.WriteLine("Goals loaded successfully.");
        }
        else
        {
            Console.WriteLine("File not found. Please try again.");
        }
    }
}
