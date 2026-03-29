namespace FinalProject;

public abstract class Aircraft(string flightNum, Pilot pilot, int minRunway)
{
    protected double Fuel = 100.0;
    private FlightState _currentState = FlightState.EnRoute;

    public virtual void UpdateFuel(double weatherMod)
    {
        Fuel -= (1.5 * weatherMod * pilot.GetSkill());
        if (Fuel <= 0) _currentState = FlightState.Crashed;
    }

    public abstract double GetLandingPriority(double weatherMod);

    public string GetInfo() => $"[{flightNum}] Fuel: {(int)Fuel}% | Status: {_currentState}";
    public int GetRequiredLength() => minRunway;
    public string GetId() => flightNum;

    public void SetState(FlightState s) => _currentState = s;

    public FlightState GetState() => _currentState;
}