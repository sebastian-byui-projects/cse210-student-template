namespace Develop02;

public class Entry(DateTime date, string prompt, string response)
{
    public DateTime GetDate()
    {
        return date;
    }

    public string GetPrompt()
    {
        return prompt;
    }

    public string GetResponse()
    {
        return response;
    }
}