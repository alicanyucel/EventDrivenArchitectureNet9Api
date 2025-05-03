
using EventDrivenArchitectureNet9Api.Events;
using EventDrivenArchitectureNet9Api.Services.Abstract;

namespace EventDrivenArchitectureNet9Api.Services.Concrete;
public class AuditService : IAuditService
{
    public void Subscribe(IWeatherForecastService weatherForecastService)
    {
        weatherForecastService.OnWeatherTransactionProcessed += WriteAuditLog;
    }

    private void WriteAuditLog(object sender, WaeatherForecastEventArgs e)
    {
        Console.WriteLine($"AUDIT LOG: {e.Day} günlük hava durumu sorgulandı.");
    }
}