namespace Develop02;

public interface IJournalServices
{
    void SaveJournalToFile(Journal journal);
    void ReadJournalFromFile(Journal journal);
}