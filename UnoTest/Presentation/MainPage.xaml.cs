namespace UnoTest.Presentation;

public sealed partial class MainPage : Page
{
    public MainPage()
    {
        InitializeComponent();
    }

    private void Button_Click(object sender, RoutedEventArgs e)
    {
        var dc = DataContext;
    }

    private void OnDarkModeToggleToggled(object sender, RoutedEventArgs e)
    {
        var darkModeToggle = (ToggleSwitch)sender;
        var theme = darkModeToggle.IsOn ? ElementTheme.Light : ElementTheme.Dark;

        SystemThemeHelper.SetApplicationTheme(XamlRoot, theme);
    }
}
