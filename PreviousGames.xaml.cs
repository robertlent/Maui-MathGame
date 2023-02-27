namespace Maui_MathApp;

public partial class PreviousGames : ContentPage
{
	public PreviousGames()
	{
		InitializeComponent();
        gamesList.ItemsSource = App.GameRepository.GetAllGames();
    }

    private void OnDelete(object sender, EventArgs e)
    {
        var button = (ImageButton)sender;
        App.GameRepository.Delete((int)button.BindingContext);
        gamesList.ItemsSource = App.GameRepository.GetAllGames();
    }
}