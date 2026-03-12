namespace Develop03;

public class Word(string text)
{
    private bool _isHidden = false;

    public void Hide() => _isHidden = true;

    public void Show() => _isHidden = false;

    public bool IsHidden() => _isHidden;

    public string GetDisplayText()
    {
        return _isHidden ? new string('_', text.Length) : text;
    }
}