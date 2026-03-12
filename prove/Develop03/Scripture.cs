namespace Develop03;

public class Scripture
{
    private readonly Reference _reference;
    private readonly List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = [];

        var splitText = text.Split(' ');
        foreach (var wordText in splitText)
        {
            _words.Add(new Word(wordText));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        var random = new Random();
        var hiddenCount = 0;


        while (hiddenCount < numberToHide && !IsCompletelyHidden())
        {
            var index = random.Next(_words.Count);
            if (_words[index].IsHidden()) continue;
            _words[index].Hide();
            hiddenCount++;
        }
    }

    public string GetDisplayText()
    {
        var scriptureText = string.Join(" ", _words.Select(w => w.GetDisplayText()));
        return $"{_reference.GetDisplayText()} {scriptureText}";
    }

    public bool IsCompletelyHidden()
    {
        return _words.All(w => w.IsHidden());
    }
}