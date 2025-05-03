
using EventDrivenArchitectureNet9Api.Events;
using EventDrivenArchitectureNet9Api.Services.Abstract;

namespace EventDrivenArchitectureNet9Api.Services.Concrete;

public class WeatherForecastService : IWeatherForecastService
{
    public event EventHandler<WaeatherForecastEventArgs> OnWeatherTransactionProcessed;

    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    public IEnumerable<WeatherForecast> GetWeatherForecast(int days)
    {
        var rng = new Random();

        var weatherForecasts = Enumerable.Range(1, days).Select(index => new WeatherForecast
        {
            Date = DateTime.Now.AddDays(index),
            TemperatureC = rng.Next(-20, 55),
            Summary = Summaries[rng.Next(Summaries.Length)]
        })
        .ToArray();

        OnWeatherTransactionProcessed?.Invoke(this, new WaeatherForecastEventArgs(days));

        return weatherForecasts;
    }
}
