namespace Develop02;

public class Journal
{
    private readonly List<Entry> _entries = [];

    public List<Entry> GetEntries()
    {
        return _entries;
    }

    public void DisplayJournal()
    {
        foreach (var entry in GetEntries().Where(entry => !entry.IsPrivate()))
        {
            Console.WriteLine($"{entry.GetDate()}: {entry.GetPrompt()} - {entry.GetResponse()} - {(entry.IsPrivate() ? "Private" : "Public")}");
        }
    }

    public void CreateJournalEntry(string prompt, string response, bool isPrivate)
    {
        var entry = new Entry(DateTime.Now, prompt, response, isPrivate);
        GetEntries().Add(entry);
    }

    public void DisplayPrivateEntries()
    {
        foreach (var entry in GetEntries().Where(entry => entry.IsPrivate()))
        {
            Console.WriteLine($"{entry.GetDate()}: {entry.GetPrompt()} - {entry.GetResponse()} - {(entry.IsPrivate() ? "Private" : "Public")}");
        }
    }
}