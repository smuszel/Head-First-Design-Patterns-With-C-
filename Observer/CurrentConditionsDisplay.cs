public class CurrentConditionsDisplay: IObserver, IDisplay
{
    private float temperature;
    private float humidity;
    private ISubject weatherData;

    public CurrentConditionsDisplay(ISubject weatherData)
    {
        this.weatherData = weatherData;
        weatherData.RegisterObserver(this);
    }

    public void Update(float temperature, float humidity, float _)
    {
        this.temperature = temperature;
        this.humidity = humidity;
        Display();
    }

    public void Display()
    {
        System.Console.WriteLine($"Current conditions: {temperature} degrees and {humidity} % humidity");
    }
}