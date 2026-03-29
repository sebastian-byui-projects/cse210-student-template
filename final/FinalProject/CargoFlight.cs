namespace FinalProject;

public class CargoFlight(string flightNum, Pilot pilot) : Aircraft(flightNum, pilot, 2500)
{
    public override double GetLandingPriority(double weatherMod)
    {
        return (5 / (Fuel / 100.0)) * weatherMod;
    }
}