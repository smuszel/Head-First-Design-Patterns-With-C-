using System;

public class TheaterLights
{
    public void Dim(int p)
    {
        System.Console.WriteLine($"Theather ceiling lights dimmed to {p} %");
    }

    public void On()
    {
        System.Console.WriteLine("Theather ceiling lights on");
    }
}