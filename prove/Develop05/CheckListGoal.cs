namespace Develop05;

public class ChecklistGoal(
    string name,
    string description,
    string points,
    int target,
    int bonus,
    int amountCompleted = 0)
    : Goal(name, description, points)
{
    private int _amountCompleted = amountCompleted;

    public override int RecordEvent()
    {
        _amountCompleted++;
        int earned = int.Parse(_points);
        if (_amountCompleted == target)
        {
            earned += bonus;
        }

        return earned;
    }

    public override bool IsComplete()
    {
        return _amountCompleted >= target;
    }

    public override string GetDetailsString()
    {
        return $"{base.GetDetailsString()} -- Currently completed: {_amountCompleted}/{target}";
    }

    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal:{_shortName},{_description},{_points},{bonus},{target},{_amountCompleted}";
    }
}