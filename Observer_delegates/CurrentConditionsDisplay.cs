public class CurrentConditionsDisplay
{
    private float temperature;
    private float humidity;

    public CurrentConditionsDisplay(IWeatherEvent weatherData)
    {
        weatherData.WeatherDataEvent += Update;
    }

    public void Update(object publisher, WeatherEventArgs e)
    {
        this.temperature = e.temperature;
        this.humidity = e.humidity;
        Display();
    }

    public void Display()
    {
        System.Console.WriteLine($"Current conditions: {temperature} degrees and {humidity} % humidity");
    }
}