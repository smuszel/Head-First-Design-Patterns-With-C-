using System;

class Program
{
    static void Main()
    {
        WeatherData weatherData = new WeatherData();
        CurrentConditionsDisplay currentDisplay = new CurrentConditionsDisplay(weatherData);
        AnotherDisplay heatDisplay = new AnotherDisplay(weatherData);

        weatherData.SetMeasurments(80, 65, 30.4f);
        weatherData.SetMeasurments(82, 70, 29.8f);
        weatherData.SetMeasurments(78, 90, 29.7f);

    }
}
