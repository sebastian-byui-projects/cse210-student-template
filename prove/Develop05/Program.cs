namespace Develop05;

class Program 
{ 
    static void Main(string[] args) 
    { 
        /* EXCEEDING REQUIREMENTS:
           Added a dynamic leveling system that calculates your level and assigns
           a fun rank title like 'Level 13 Ninja Unicorn' based on your total points
           to increase gamification.
        */ 
        GoalManager manager = new GoalManager(); 
        manager.Start(); 
    } 
}