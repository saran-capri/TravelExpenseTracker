using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
using TravelExpenseTracker.Pages;
using TravelExpenseTracker.ViewModels;

namespace TravelExpenseTracker;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("Poppins-Regular.ttf", "PoppinsRegular");
				fonts.AddFont("Poppins-Semibold.ttf", "Poppinsbold");
			})
			.UseMauiCommunityToolkit();

#if DEBUG
		builder.Logging.AddDebug();
#endif
		builder.Services.AddTransient<LoginViewModel>().AddTransient<LoginPage>();
		builder.Services.AddTransient<RegisterViewModel>().AddTransient<RegisterPage>();
		builder.Services.AddSingleton<HomeViewModel>().AddSingleton<MainPage>();
		builder.Services.AddSingleton<TripsViewModel>().AddSingleton<TripsPage>();


		return builder.Build();
	}
}
