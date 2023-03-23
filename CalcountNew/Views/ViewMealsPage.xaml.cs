using CalcountNew.ViewModels;
using MauiApp1.Models;
using Calcount.Domain.Repositories.EntityFramework;
using Calcount;

namespace CalcountNew.Views;

public partial class ViewMealsPage : ContentPage
{
    private EFMealsRepository db = new EFMealsRepository(MauiProgram.Context);

    public ViewMealsPage(ViewMealsPageViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}

    private async void OnItemSelected(object sender, SelectedItemChangedEventArgs args)
    {
        Meal meal = args.SelectedItem as Meal;
        await db.RemoveMealAsync(meal);
        var previousPage = Navigation.NavigationStack.LastOrDefault();
        await Shell.Current.GoToAsync($"{nameof(ViewMealsPage)}");
        Navigation.RemovePage(previousPage);
    }
}