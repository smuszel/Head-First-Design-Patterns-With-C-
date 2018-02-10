using System;
public interface IWeatherEvent
{
    event EventHandler<WeatherEventArgs> WeatherDataEvent;
}