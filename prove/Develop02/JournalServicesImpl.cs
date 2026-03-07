namespace Develop02;

public class JournalServicesImpl : IJournalServices
{
    private const string FilePath = "./journal.txt";

    public void SaveJournalToFile(Journal journal)
    {
        using var writer = new StreamWriter(FilePath);
        foreach (var entry in journal.GetEntries())
        {
            writer.WriteLine($"{entry.GetDate()}|{entry.GetPrompt()}|{entry.GetResponse()}");
        }
    }

    public Journal ReadJournalFromFile(Journal journal)
    {
        var entries = journal.GetEntries();

        if (!File.Exists(FilePath))
        {
            Console.WriteLine("No journal file found.");
            return new Journal();
        }

        entries.Clear();

        using var reader = new StreamReader(FilePath);
        while (reader.ReadLine() is { } line)
        {
            var parts = line.Split('|');
            if (parts.Length != 3) continue;
            var date = DateTime.Parse(parts[0]);
            var prompt = parts[1];
            var response = parts[2];
            var entry = new Entry(date, prompt, response);
            entries.Add(entry);
        }

        return journal;
    }
}