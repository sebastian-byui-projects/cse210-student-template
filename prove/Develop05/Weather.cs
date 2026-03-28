namespace Develop05;

public class Weather
{
    private string _condition = "Clear";
    private double _modifier = 1.0;


    public string GetCondition()
    {
        return _condition;
    }

    public double GetModifier()
    {
        return _modifier;
    }


    public void UpdateWeather()
    {
        string[] conditions = ["Clear", "Rainy", "Foggy", "Thunderstorm"];
        double[] modifiers = [1.0, 1.2, 1.5, 2.2];

        var rnd = new Random();
        var index = rnd.Next(conditions.Length);

        _condition = conditions[index];
        _modifier = modifiers[index];
    }
}