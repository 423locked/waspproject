using Calcount.Domain.Providers;
using Calcount.ViewModels;
using CommunityToolkit.Maui;

namespace Calcount.Views;

public partial class AddMealPage : ContentPage
{
	public AddMealPage(AddMealPageViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}