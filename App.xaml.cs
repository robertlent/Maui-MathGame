using Maui_MathApp.Data;

namespace Maui_MathApp;

public partial class App : Application
{
    public static GameRepository GameRepository { get; private set; }

    public App(GameRepository gameRepository)
    {
		InitializeComponent();

		MainPage = new AppShell();

        GameRepository = gameRepository;
    }
}
