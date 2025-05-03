

using EventDrivenArchitectureNet9Api.Events;

namespace EventDrivenArchitectureNet9Api.Services.Abstract;

public interface IWeatherForecastService
{
    event EventHandler<WaeatherForecastEventArgs> OnWeatherTransactionProcessed;
    IEnumerable<WeatherForecast> GetWeatherForecast(int days);
}
