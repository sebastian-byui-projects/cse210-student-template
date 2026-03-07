using System;
using Develop02;

class Program
{
    static void Main(string[] args)
    {
        var journal = new Journal();
        var journalServices = new JournalServicesImpl();
        var menu = new Menu(journal, journalServices);
        menu.Run();
    }
}