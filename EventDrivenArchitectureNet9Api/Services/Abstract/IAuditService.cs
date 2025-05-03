

namespace EventDrivenArchitectureNet9Api.Services.Abstract;

public interface IAuditService
{
    void Subscribe(IWeatherForecastService weatherForecastService);
}
