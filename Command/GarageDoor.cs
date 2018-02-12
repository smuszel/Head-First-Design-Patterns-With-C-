public class GarageDoor
{
    public string location;
    public GarageDoor(string location)
    {
        this.location = location;
    }
    public void Up()
    {
        System.Console.WriteLine($"Garage door is up");
    }

    public void Down()
    {
        System.Console.WriteLine($"Garage door is down");
    }
}