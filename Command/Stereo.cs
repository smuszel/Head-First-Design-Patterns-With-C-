public class Stereo
{
    public int Volume { get; set; }

    public bool CD { get; set; }

    public string location;

    public Stereo(string location)
    {
        this.location = location;
    }

    public void On()
    {
        System.Console.WriteLine("Stereo is on");
    }
    public void Off()
    {
        System.Console.WriteLine("Stereo is off");
    }
}