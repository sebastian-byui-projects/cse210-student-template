namespace Develop05;

public class Gate(int number)
{
    private bool _isFull = false;


    public int GetNumber()
    {
        return number;
    }

    public bool IsFull()
    {
        return _isFull;
    }

    public void SetIsFull(bool isFull)
    {
        _isFull = isFull;
    }
}