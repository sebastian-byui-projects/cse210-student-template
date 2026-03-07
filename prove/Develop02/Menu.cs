namespace Develop02;

public class Menu(Journal journal, IJournalServices journalServices)
{
    private readonly List<string> _options =
    [
        "Welcome to the Journal Program!",
        "Create, Display, Save and Load Journal Entries",
        "1 - Create Journal Entry",
        "2 - Display Journal",
        "3 - Save Journal to file",
        "4 - Read Journal from file",
        "5 - Exit"
    ];

    private readonly List<string> _prompts =
    [
        "What was the best part of your day?",
        "What are you grateful for today?",
        "What did you learn today?",
        "What is something you want to improve on?",
        "What made you smile today?"
    ];


    public void Run()
    {
        while (true)
        {
            Console.WriteLine(string.Join("\n", _options));
            var choice = Console.ReadLine() ?? "";
            switch (choice)
            {
                case "1":
                    var prompt = _prompts[new Random().Next(_prompts.Count)];
                    journal.CreateJournalEntry(prompt);
                    break;
                case "2":
                    journal.DisplayJournal();
                    break;
                case "3":
                    journalServices.SaveJournalToFile(journal);
                    break;
                case "4":
                    journalServices.ReadJournalFromFile(journal);
                    journal.DisplayJournal();
                    break;
                case "5":
                    Console.WriteLine("Exit");
                    return;
                default:
                    Console.WriteLine("Invalid choice, please try again.");
                    break;
            }
        }
    }
}