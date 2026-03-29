namespace Develop05;

public abstract class Goal(string name, string description, string points)
{ 
    protected string _shortName = name; 
    protected string _description = description; 
    protected string _points = points;

    public abstract int RecordEvent(); 
    public abstract bool IsComplete(); 

    public virtual string GetDetailsString() 
    { 
        return $"[{(IsComplete() ? "X" : " ")}] {_shortName} ({_description})"; 
    } 

    public abstract string GetStringRepresentation(); 
}