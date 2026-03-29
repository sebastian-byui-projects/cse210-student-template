namespace FinalProject;

public class ControlTower
{
    private List<Aircraft> _airspace = [];
    private List<Runway> _runways = [];
    private List<Gate> _gates = [];
    private Weather _weather = new Weather();

    public ControlTower()
    {
        _runways.Add(new Runway("Alpha-Long", 3000));
        _runways.Add(new Runway("Beta-Short", 1800));
        _gates.Add(new Gate(1));
        _gates.Add(new Gate(2));
    }

    public void AddIncomingFlight(Aircraft a) => _airspace.Add(a);

    public void SimulationStep()
    {
        GenerateRandomFlight();
        RefreshResources();
        _weather.UpdateWeather();
        Console.WriteLine($"\n>> WEATHER: {_weather.GetCondition()} (Modifier: {_weather.GetModifier()}x)");

        foreach (var plane in _airspace.ToList())
        {
            plane.UpdateFuel(_weather.GetModifier());
            if (plane.GetState() == FlightState.Crashed)
            {
                Console.WriteLine($"\n[CRITICAL] {plane.GetId()} HAS CRASHED! Emergency teams deployed.");
                _airspace.Remove(plane);
            }
        }

        _airspace = _airspace.OrderByDescending(p => p.GetLandingPriority(_weather.GetModifier())).ToList();
    }

    public void DisplayStatus()
    {
        Console.WriteLine("--- Current Airspace ---");
        foreach (var plane in _airspace) Console.WriteLine(plane.GetInfo());
    }


    public void ExecuteLanding()
    {
        if (_airspace.Count == 0) return;

        var plane = _airspace[0];

        var runway = _runways.FirstOrDefault(r => !r.IsOccupied() && r.GetLenght() >= plane.GetRequiredLength());

        var gate = _gates.FirstOrDefault(g => !g.IsFull());

        if (runway != null && gate != null)
        {
            Console.WriteLine($"\n[SUCCESS] {plane.GetId()} landed on {runway.GetId()}.");
            Console.WriteLine($"[INFO] {plane.GetId()} is now parked at Gate {gate.GetNumber()}.");


            gate.SetIsFull(true);

            _airspace.RemoveAt(0);
        }
        else
        {
            Console.WriteLine(gate == null
                ? "\n[DELAY] All Gates are FULL! Wait for someone to leave."
                : "\n[DELAY] No suitable Runway available for this aircraft size.");
        }
    }

    private void RefreshResources()
    {
        Random rnd = new Random();
        foreach (var gate in _gates)
        {
            if (gate.IsFull() && rnd.Next(1, 11) > 7) // 30% de chance
            {
                gate.SetIsFull(false);
                Console.WriteLine($"[TOWER] Gate {gate.GetNumber()} is now EMPTY. (A plane has departed)");
            }
        }
    }
    

    public void GenerateRandomFlight()
    {
        Random rnd = new Random();
        
        if (rnd.Next(1, 11) > 7)
        {
            string[] airlines = { "Delta", "United", "FedEx", "DHL", "Iberia", "NASA" };
            string[] pilotNames = { "EagleEye", "Maverick", "Iceman", "SkyWalker" };
            
            string flightId = $"{airlines[rnd.Next(airlines.Length)]}-{rnd.Next(100, 999)}";
            Pilot randomPilot = new Pilot(pilotNames[rnd.Next(pilotNames.Length)], 0.8 + (rnd.NextDouble() * 0.5));
            
            int type = rnd.Next(1, 4); // 1, 2 o 3
            Aircraft newPlane;

            if (type == 1)
                newPlane = new ComercialFlight(flightId, randomPilot);
            else if (type == 2)
                newPlane = new CargoFlight(flightId, randomPilot);
            else
                newPlane = new EmergencyFlight(flightId, randomPilot);
            
            AddIncomingFlight(newPlane);

            Console.WriteLine(
                $"\n[RADAR] New contact detected: {flightId} ({newPlane.GetType().Name}) has entered the airspace!");
        }
    }
}