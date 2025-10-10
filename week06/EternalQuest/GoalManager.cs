using System.IO;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void AddPoints(int points)
    {
        _score += points;
    }

    public void Start()
    {
        while (true)
        {
            DisplayPlayerInfo();
            GoalMenu.DisplayMenu();
            string choice = GoalMenu.GetUserChoice();
            SelectOption(choice);
        }
    }

    private void SelectOption(string option)
    {
        if (option == "1")
        {
            CreateGoal();
        }
        else if (option == "2")
        {
            ListGoalDetails();
        }
        else if (option == "3")
        {
            RecordEvent();
        }
        else if (option == "4")
        {
            Console.Write("What file would you like to save to? ");
            string filename = Console.ReadLine();
            Save(filename);
        }
        else if (option == "5")
        {
            Console.Write("What file would you like to load from? ");
            string filename = Console.ReadLine();
            Load(filename);
        }
        else if (option == "6")
        {
            Exit();
        }
    }

    private void DisplayPlayerInfo()
    {
        Console.WriteLine($"\nYou have {_score} points.");
    }

    private void ListGoalNames()
    {
        int i = 0;
        Console.WriteLine();
        foreach (Goal goal in _goals)
        {
            i++;
            Console.WriteLine($"{i}: {goal.GetName()}");
        }
    }

    private void ListGoalDetails()
    {
        int i = 0;
        Console.WriteLine();
        foreach (Goal goal in _goals)
        {
            i++;
            Console.WriteLine($"{i}: {goal.GetStringDetails()}");
        }
    }

    private void ListGoalTypes()
    {
        string goalTypesString = """
        
        The types of goals are:
          1. Simple Goal
          2. Eternal Goal
          3. Checklist Goal
        """;
        Console.WriteLine(goalTypesString);
    }

    private void CreateGoal()
    {
        ListGoalTypes();
        Console.Write("\nWhat type of goal would you like to create? ");
        string goalType = Console.ReadLine();
        Console.Write("What is the name of your goal? ");
        string goalName = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string goalDesc = Console.ReadLine();
        Console.Write("How many points is this goal worth to you? ");
        string goalPoints = Console.ReadLine();
        if (goalType == "1")
        {
            SimpleGoal newSGoal = new SimpleGoal(goalName, goalDesc, int.Parse(goalPoints));
            _goals.Add(newSGoal);
        }
        else if (goalType == "2")
        {
            EternalGoal newEGoal = new EternalGoal(goalName, goalDesc, int.Parse(goalPoints));
            _goals.Add(newEGoal);
        }
        else if (goalType == "3")
        {
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            string goalTarget = Console.ReadLine();
            Console.Write("What is the bonus for accomplishing it that many times? ");
            string bonusPoints = Console.ReadLine();
            ChecklistGoal newCGoal = new ChecklistGoal(goalName, goalDesc, int.Parse(goalPoints), int.Parse(goalTarget), int.Parse(bonusPoints));
            _goals.Add(newCGoal);
        }
    }

    private void RecordEvent()
    {
        ListGoalNames();
        Console.Write("\nWhich goal did you accomplish? ");
        string goalNum = Console.ReadLine();
        int goalIndex = int.Parse(goalNum) - 1;
        _goals[goalIndex].RecordEvent(this);
    }

    private void Save(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetRepresentationString());
            }
        }
    }

    private void Load(string filename)
    {
        string[] lines = File.ReadAllLines(filename);
        int score = int.Parse(lines[0]);
        _score = score;

        foreach (string line in lines.Skip(1))
        {
            string[] parts = line.Split(Goal.GetDelimiter());

            string goalType = parts[0];

            if (goalType == "1" || goalType == "SimpleGoal")
            {
                SimpleGoal newSGoal = new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]), parts[4]);
                _goals.Add(newSGoal);
            }
            else if (goalType == "2" || goalType == "EternalGoal")
            {
                EternalGoal newEGoal = new EternalGoal(parts[1], parts[2], int.Parse(parts[3]));
                _goals.Add(newEGoal);
            }
            else if (goalType == "3" || goalType == "ChecklistGoal")
            {
                ChecklistGoal newCGoal = new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[5]), int.Parse(parts[4]), int.Parse(parts[6]));
                _goals.Add(newCGoal);
            }
        }
    }

    private void Exit()
    {
        Environment.Exit(0);
    }
}