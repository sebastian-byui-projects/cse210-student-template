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
        foreach (var entry in GetEntries())
        {
            Console.WriteLine($"{entry.GetDate()}: {entry.GetPrompt()} - {entry.GetResponse()}");
        }
    }
    
    public void CreateJournalEntry(string prompt)
    {
        Console.WriteLine(prompt);
        var response = Console.ReadLine() ?? "";
        var entry = new Entry(DateTime.Now, prompt, response);
        GetEntries().Add(entry);
    }
}