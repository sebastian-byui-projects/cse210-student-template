namespace Develop02;

public class Entry(DateTime date, string prompt, string response, bool isPrivate = true)
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
    
    public bool IsPrivate()
    {
        return isPrivate;
    }
}