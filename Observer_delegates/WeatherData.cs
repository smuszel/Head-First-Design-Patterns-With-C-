using System.Collections.Generic;
using System;

public class WeatherData: IWeatherEvent
{
    private float temperature;
    private float humidity;
    private float pressure;

    // With generic delegate there is no need for below
    // public delegate void WeatherDataEventHandler(float temperature, float humidity, float pressure);
    // public delegate void WeatherDataEventHandler(object sender, WeatherEventArgs e);
    public event EventHandler<WeatherEventArgs> WeatherDataEvent;

    public void NotifyObservers()
    {
        WeatherEventArgs e = new WeatherEventArgs();
        e.temperature = temperature;
        e.humidity = humidity;
        e.pressure = pressure;

        WeatherDataEvent(this, e);
    }

    public void SetMeasurments(float temperature, float humidity, float pressure)
    {
        this.temperature = temperature;
        this.humidity = humidity;
        this.pressure = pressure;

        NotifyObservers();
    }
}