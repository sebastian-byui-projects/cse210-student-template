namespace Develop05;

public class ComercialFlight(string flightNum, Pilot pilot) : Aircraft(flightNum, pilot, 2000)
{
    public override double GetLandingPriority(double weatherMod)
    {
        return (10 / (Fuel / 100.0)) * weatherMod;
    }
}