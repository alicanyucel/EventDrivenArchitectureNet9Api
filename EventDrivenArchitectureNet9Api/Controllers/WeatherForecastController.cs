using EventDrivenArchitectureNet9Api.Services.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace EventDrivenArchitectureNet9Api.Controllers;

[ApiController]
[Route("api/[controller]/[action]")]
public class WeatherForecastController : ControllerBase
{

    private readonly IWeatherForecastService _weatherForecastService;
    private readonly IAuditService _auditService;

    public WeatherForecastController(IWeatherForecastService weatherForecastService, IAuditService auditService)
    {
        _weatherForecastService = weatherForecastService;
        _auditService = auditService;
        _auditService.Subscribe(_weatherForecastService);
    }

    [HttpGet]
    public IEnumerable<WeatherForecast> Get(int days)
    {
        var weatherForecasts = _weatherForecastService.GetWeatherForecast(days);
        return weatherForecasts;
    }
}
