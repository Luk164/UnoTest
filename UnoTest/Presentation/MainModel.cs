namespace UnoTest.Presentation;

using Uno.Extensions.Reactive;

public partial record MainModel
{
    private INavigator _navigator;

    public MainModel(
        IStringLocalizer localizer,
        IOptions<AppConfig> appInfo,
        INavigator navigator)
    {
        _navigator = navigator;
        Title = "Main";
        Title += $" - {localizer["ApplicationName"]}";
        Title += $" - {appInfo?.Value?.Environment}";
    }

    public string? Title { get; }

    public IState<string> Name => State<string>.Value(this, () => string.Empty);

    public IFeed<WeatherInfo> CurrentWeather => Feed.Async(GetWeatherAsync);

    private static async ValueTask<WeatherInfo> GetWeatherAsync(CancellationToken ct)
    {
        await Task.Delay(250, ct);
        return new WeatherInfo();
    }

    public async Task GoToSecond()
    {
        var name = await Name;
        await _navigator.NavigateViewModelAsync<SecondModel>(this, data: new Entity(name!));
    }
}

public class WeatherInfo
{
    public string? Summary { get; set; } = "Foo";
    public double TemperatureC { get; set; }
}
