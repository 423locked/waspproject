using Calcount.Domain;
using Calcount.ViewModels;
using Calcount.Views;
using CalcountNew.ViewModels;
using CommunityToolkit.Maui;
using CalcountNew.Views;

namespace Calcount;

public static class MauiProgram
{
	public static CalcountDbContext Context { get; set; }

	public static MauiApp CreateMauiApp()
	{
		Context = new CalcountDbContext();
		Context.Database.EnsureCreated();

		var builder = MauiApp.CreateBuilder();
		builder
            .UseMauiApp<App>()
            .UseMauiCommunityToolkit()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
				fonts.AddFont("Poppins-Regular.ttf", "PoppinsRegular");
				fonts.AddFont("Poppins-Medium.ttf", "PoppinsMedium");
                fonts.AddFont("Poppins-Bold.ttf", "PoppinsBold");

            });

		builder.Services.AddTransient<AddMealPage>();
		builder.Services.AddTransient<AddMealPageViewModel>();

		builder.Services.AddTransient<MainPage>();
		builder.Services.AddTransient<MainPageViewModel>();

		builder.Services.AddTransient<ViewMealsPage>();
		builder.Services.AddTransient<ViewMealsPageViewModel>();

        return builder.Build();
	}
}
