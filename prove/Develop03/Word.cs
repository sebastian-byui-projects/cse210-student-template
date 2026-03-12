namespace Develop03;

public class Word(string text)
{
    private bool _isHidden;

    public void Hide() => _isHidden = true;

    public bool IsHidden() => _isHidden;

    public string GetDisplayText()
    {
        return _isHidden ? new string('_', text.Length) : text;
    }
}