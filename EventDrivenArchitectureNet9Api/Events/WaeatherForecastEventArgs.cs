namespace EventDrivenArchitectureNet9Api.Events;

public class WaeatherForecastEventArgs:EventArgs
{
    public int Day { get; set; }
    public WaeatherForecastEventArgs(int day)
    {
        Day = day;
    }
}
