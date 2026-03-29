namespace FinalProject;

class Program
{
    static void Main(string[] args)
    {
        ControlTower tower = new ControlTower();
        
        tower.AddIncomingFlight(new ComercialFlight("Delta-402", new Pilot("Sarah", 0.9)));
        tower.AddIncomingFlight(new CargoFlight("FedEx-99", new Pilot("Mike", 1.3)));
        tower.AddIncomingFlight(new EmergencyFlight("MEDEVAC-1", new Pilot("Ace", 0.8)));

        string command = "";
        Console.WriteLine("SkyLink ATC System Activated.");

        while (command != "exit")
        {
            tower.SimulationStep();
            tower.DisplayStatus();

            Console.WriteLine("\nCommands: [land] [wait] [exit]");
            command = Console.ReadLine()?.ToLower();

            if (command == "land") tower.ExecuteLanding();
        }
    }
}