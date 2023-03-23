using Calcount.Views;
using CalcountNew.Views;

namespace Calcount;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new AppShell();

		Routing.RegisterRoute(nameof(AddMealPage), typeof(AddMealPage));
		Routing.RegisterRoute(nameof(ViewMealsPage), typeof(ViewMealsPage));
	}
}
