using Calcount;
using Calcount.Domain.Repositories.EntityFramework;
using Calcount.Views;
using CommunityToolkit.Mvvm;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace CalcountNew.ViewModels
{
    public partial class MainPageViewModel : ObservableObject
    {
        private EFMealsRepository db = new EFMealsRepository(MauiProgram.Context);

        [ObservableProperty]
        private string welcomeSign;

        [ObservableProperty]
        private string buttonText;

        public MainPageViewModel()
        {
            WelcomeSign = "Welcome to Calcount! Count your nutrients without hesitation!";
            ButtonText = "Try Calcount";
        }

        [RelayCommand]
        private async Task AddMeal()
            => await Shell.Current.GoToAsync($"{nameof(AddMealPage)}");
    }


}
