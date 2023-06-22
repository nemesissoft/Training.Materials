namespace TradingSystem;

public delegate void UpdateTimeEventHandler(TimeSpan time);

public delegate void SetTimeEventHandler(DateTime time);

public class TimeSimulator : ITimeSimulator
{
    public event UpdateTimeEventHandler OnUpdateTime;
    public event SetTimeEventHandler OnSetTime;

    public void SetTimeTo(DateTime time) => OnSetTime?.Invoke(time);

    public void UpdateTimeBy(TimeSpan time) => OnUpdateTime?.Invoke(time);
}

public interface ITimeSimulator
{
    void SetTimeTo(DateTime time);
    void UpdateTimeBy(TimeSpan time);

    event UpdateTimeEventHandler OnUpdateTime;
    event SetTimeEventHandler OnSetTime;
}