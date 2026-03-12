using Develop03;

class Program
{
    static void Main(string[] args)
    {
        var ref1 = new Reference("Proverbs", 3, 5, 6);
        const string text =
            "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.";
        var scripture = new Scripture(ref1, text);

        var input = "";

        while (input != null && !input.Equals("quit", StringComparison.CurrentCultureIgnoreCase) &&
               !scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress enter to hide words or type 'quit' to finish:");

            input = Console.ReadLine();

            if (input != null && !input.Equals("quit", StringComparison.CurrentCultureIgnoreCase))
            {
                scripture.HideRandomWords(3);
            }
        }

        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine("\nGoodbye!");
    }
}