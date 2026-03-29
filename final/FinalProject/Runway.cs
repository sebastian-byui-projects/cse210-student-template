namespace FinalProject;

public class Runway(string id, int lenght)
{
    private bool _isOccupied = false;


    public string GetId()
    {
        return id;
    }

    public int GetLenght()
    {
        return lenght;
    }

    public bool IsOccupied()
    {
        return _isOccupied;
    }

    public void SetIsOccupied(bool isOccupied)
    {
        _isOccupied = isOccupied;
    }
}