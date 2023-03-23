using Calcount.Domain.Providers;
using Calcount.Domain.Repositories.EntityFramework;
using Calcount.ViewModels;
using Calcount.Views;
using CalcountNew.ViewModels;
using MauiApp1.Models;

namespace Calcount;

public partial class MainPage : ContentPage
{
	public MainPage(MainPageViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}

