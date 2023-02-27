using Maui_MathApp.Data;
using Microsoft.Extensions.Logging;

namespace Maui_MathApp;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts => { fonts.AddFont("CaveatBrush-Regular.ttf", "CaveatBrushRegular"); });

        var dbPath = Path.Combine(FileSystem.AppDataDirectory, "game.db");

        builder.Services.AddSingleton(s =>
            ActivatorUtilities.CreateInstance<GameRepository>(s, dbPath));

        return builder.Build();
	}
}
