using System;

public class DvdPlayer
{
    public void On()
    {
        System.Console.WriteLine("Dvd player on");
    }

    public void Off()
    {
        System.Console.WriteLine("Dvd player off");
    }
    public void Play(string movie)
    {
        System.Console.WriteLine($"Playing \"{movie}\"");
    }

    public void Stop()
    {
        System.Console.WriteLine("Dvd player stopped");
    }

    public void Eject()
    {
        System.Console.WriteLine("Dvd player ejected");
    }
}