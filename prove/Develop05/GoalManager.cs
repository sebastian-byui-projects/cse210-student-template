namespace Develop05;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void Start()
    {
        bool quit = false;
        while (!quit)
        {
            Console.WriteLine($"\nYou have {_score} points. Level: {(_score / 1000) + 1} Title: {GetTitle()}");
            Console.WriteLine("Menu Options:\n  1. Create New Goal\n  2. List Goals\n  3. Record Event\n  4. Quit");
            Console.Write("Select a choice: ");
            
            string choice = Console.ReadLine();
            
            if (choice == "1") CreateGoal();
            else if (choice == "2") ListGoalDetails();
            else if (choice == "3") RecordEvent();
            else if (choice == "4") quit = true;
        }
    }

    private string GetTitle()
    {
        int level = (_score / 1000) + 1;
        if (level == 1) return "Novice";
        if (level == 2) return "Apprentice";
        if (level == 3) return "Journeyman";
        return "Level 13 Ninja Unicorn";
    }

    private void ListGoalDetails()
    {
        Console.WriteLine("The goals are:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }

    private void CreateGoal()
    {
        Console.WriteLine("The types of Goals are:\n  1. Simple Goal\n  2. Eternal Goal\n  3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        string type = Console.ReadLine();
        
        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        
        Console.Write("What is a short description of it? ");
        string desc = Console.ReadLine();
        
        Console.Write("What is the amount of points associated with this goal? ");
        string points = Console.ReadLine();
        
        if (type == "1") 
        {
            _goals.Add(new SimpleGoal(name, desc, points));
        }
        else if (type == "2") 
        {
            _goals.Add(new EternalGoal(name, desc, points));
        }
        else if (type == "3") 
        {
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int target = int.Parse(Console.ReadLine());
            Console.Write("What is the bonus for accomplishing it that many times? ");
            int bonus = int.Parse(Console.ReadLine());
            _goals.Add(new ChecklistGoal(name, desc, points, target, bonus));
        }
    }

    private void RecordEvent()
    {
        ListGoalDetails();
        Console.Write("Which goal did you accomplish? ");
        int index = int.Parse(Console.ReadLine()) - 1;
        int pointsEarned = _goals[index].RecordEvent();
        _score += pointsEarned;
        Console.WriteLine($"Congratulations! You have earned {pointsEarned} points!");
    }
}