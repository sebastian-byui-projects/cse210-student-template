namespace Develop05;

public class EternalGoal(string name, string description, string points) : Goal(name, description, points)
{
    public override int RecordEvent() 
    { 
        return int.Parse(_points); 
    } 

    public override bool IsComplete() 
    { 
        return false; 
    } 

    public override string GetStringRepresentation() 
    { 
        return $"EternalGoal:{_shortName},{_description},{_points}"; 
    } 
}