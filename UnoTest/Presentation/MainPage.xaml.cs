namespace UnoTest.Presentation;

public sealed partial class MainPage : Page
{
    public MainPage()
    {
        this.InitializeComponent();
    }

    private void Button_Click(object sender, RoutedEventArgs e)
    {
        TestFeedView.Refresh.Execute(null);
        // TestFeedView.VisualStateSelector
        var test = TestFeedView.RefreshingState;
    }
}
