using Calcount.Domain.Providers;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using Calcount;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using MauiApp1.Models;
using CalcountNew.Domain;
using Calcount.Domain.Repositories.EntityFramework;
using CalcountNew.Views;

namespace Calcount.ViewModels
{
    public partial class AddMealPageViewModel : ObservableObject
    {
        private EFMealsRepository db = new EFMealsRepository(MauiProgram.Context);

        [ObservableProperty]
        private string mealDescription;

        [ObservableProperty]
        private string foodtype;

        [ObservableProperty]
        private ObservableCollection<string> mealTypes;

        [ObservableProperty]
        private int selectedMealType;

        [ObservableProperty]
        private string result;

        [ObservableProperty]
        private List<Meal> meals;

        [ObservableProperty]
        private bool areMealsReady;

        public AddMealPageViewModel()
        {
            MealDescription = "";
            Foodtype = "Type of food (breakfast, lunch, supper)";
            MealTypes = new ObservableCollection<string>() { "breakfast", "lunch", "dinner" };
            SelectedMealType = 1;
        }
        
        partial void OnSelectedMealTypeChanged(int value)
        {
            Foodtype  = mealTypes[selectedMealType];
        }

        [RelayCommand] 
        private async Task SubmitMeal()
        {
            Result = "Processing...";
            string jsonString = await APIProvider.GetMealJsonAsync(MealDescription);

            if (jsonString == string.Empty) Result = "Wrong query! Try again";
            else if (jsonString != null)
            {
                Result = "Success!";
                AreMealsReady = true;
                JObject json = JObject.Parse(jsonString);
                Meals = JsonHelper.JsonStrToMeal(json, foodtype);
            }

            await UploadMeals();
        }

        private async Task UploadMeals()
        {
            if (Meals is not null)
                foreach (Meal meal in Meals)
                    await db.AddMealAsync(meal);
        }

        [RelayCommand]
        private async Task ViewMeals()
        {
            await Shell.Current.GoToAsync($"{nameof(ViewMealsPage)}");
        }
    }
}
