using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calcount.Domain.Providers;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using MauiApp1.Models;
using Calcount.Domain.Repositories.EntityFramework;
using Calcount;

namespace CalcountNew.ViewModels
{
    public partial class ViewMealsPageViewModel : ObservableObject
    {
        private EFMealsRepository db = new EFMealsRepository(MauiProgram.Context);

        [ObservableProperty]
        private List<Meal> meals;

        [ObservableProperty]
        private List<string> descriptions;

        [ObservableProperty]
        private List<Meal> breakfasts;

        [ObservableProperty]
        private List<Meal> lunches;

        [ObservableProperty]
        private List<Meal> dinners;

        public ViewMealsPageViewModel()
        {
            Meals = db.GetMeals().ToList();
            Breakfasts = Meals.Where(x => x.Category == "breakfast").ToList();
            Lunches = Meals.Where(x => x.Category == "lunch").ToList();
            Dinners = Meals.Where(x => x.Category == "dinner").ToList();
        }

    }
}
