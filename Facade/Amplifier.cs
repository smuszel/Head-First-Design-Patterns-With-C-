using System;

public class Amplifier
{
    public DvdPlayer Dvd { get; set; }
    public int Volume { get; set; }

    public void On()
    {
        System.Console.WriteLine("Amplifier on");
    }
    
    public void Off()
    {
        System.Console.WriteLine("Amplifier off");
    }

    public void SetSurroundSound()
    {
        System.Console.WriteLine("Amplifier surround sound on");
    }
}