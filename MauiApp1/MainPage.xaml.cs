namespace MauiApp1;

public partial class MainPage
{
    private int _count;

    public MainPage()
    {
        InitializeComponent();
    }

    private void OnCounterClicked(object sender, EventArgs e)
    {
        _count++;

        CounterBtn.Text = _count == 1 ? $"Klikket {_count} gang" : $"Klikket {_count} ganger";

        SemanticScreenReader.Announce(CounterBtn.Text);
    }
}