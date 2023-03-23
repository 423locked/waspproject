using MauiApp1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcount.Domain.Repositories.Abstract
{
    public interface IMealsRepository
    {
        IQueryable<Meal> GetMeals();
        IQueryable<Meal> GetBreakfasts();
        IQueryable<Meal> GetLunches();
        IQueryable<Meal> GetDinners();

        Meal GetMealById(Guid id);

        Task AddMealAsync(Meal meal);
        Task UpdateMealAsync(Meal meal);
        Task RemoveMealAsync(Meal meal);
    }
}
