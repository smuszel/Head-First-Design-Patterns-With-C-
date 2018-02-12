public class CeilingFan
{
    public enum speeds {OFF, LOW, MEDIUM, HIGH} 
    public string location;

    public int Speed { get; set; }
    public int PrevSpeed { get; set; }
    public CeilingFan(string location)
    {
        this.location = location;
        Speed = (int)speeds.OFF;
        PrevSpeed = (int)speeds.OFF;

    }
    public void On()
    {
        System.Console.WriteLine($"Ceiling fan is on in {location}");
    }

    public void Off()
    {
        Speed = (int)speeds.OFF;
        System.Console.WriteLine($"Ceiling fan is off in {location}");
    }

    public void Low()
    {
        Speed = (int)speeds.LOW;
        LogSpeed();
    }
    public void Medium()
    {
        Speed = (int)speeds.MEDIUM;
        LogSpeed();

    }
    public void High()
    {
        Speed = (int)speeds.HIGH;
        LogSpeed();
    }

    void LogSpeed()
    {
        System.Console.WriteLine($"Speed level is now {Speed}");
    }
    
}