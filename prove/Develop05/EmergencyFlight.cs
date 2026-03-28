namespace Develop05;

public class EmergencyFlight(string flightNum, Pilot pilot) : Aircraft(flightNum, pilot, 1500)
{
    public override double GetLandingPriority(double weatherMod)
    {
        return (15 / (Fuel / 100.0)) * 50 * weatherMod;
    }
}