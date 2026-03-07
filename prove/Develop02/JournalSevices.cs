namespace Develop02;

public interface IJournalServices
{
    void SaveJournalToFile(Journal journal);
    Journal ReadJournalFromFile(Journal journal);
}