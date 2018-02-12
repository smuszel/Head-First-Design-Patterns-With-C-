public class Light
{
    public string location;
    public Light(string location)
    {
        this.location = location;
    }
    public void On()
    {
        System.Console.WriteLine($"Light is on in {location}");
    }

    public void Off()
    {
        System.Console.WriteLine($"Light is off in {location}");
    }
}