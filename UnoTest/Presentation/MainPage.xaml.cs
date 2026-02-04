namespace UnoTest.Presentation;

public sealed partial class MainPage : Page
{
    public MainPage()
    {
        InitializeComponent();
        var dc = DataContext; // likely null
    }

    private void Button_Click(object sender, RoutedEventArgs e)
    {
        TestFeedView.Refresh.Execute(null);
        // TestFeedView.VisualStateSelector
        var test = TestFeedView.RefreshingState;
    }
}
