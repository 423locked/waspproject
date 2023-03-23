using Calcount.Domain.Repositories.Abstract;
using MauiApp1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcount.Domain.Repositories.EntityFramework
{
    public class EFMealsRepository : IMealsRepository
    {
        private readonly CalcountDbContext context;
        public EFMealsRepository(CalcountDbContext context)
        {
            this.context = context;
        }

        public IQueryable<Meal> GetMeals()
            => context.Meals;
        
        public IQueryable<Meal> GetBreakfasts()
            => context.Meals.Where(x => x.Category == "breakfast");
        public IQueryable<Meal> GetLunches()
            => context.Meals.Where(x => x.Category == "lunch");

        public IQueryable<Meal> GetDinners()
            => context.Meals.Where(x => x.Category == "dinner");

        public Meal GetMealById(Guid id)
            => context.Meals.FirstOrDefault(x => x.Id == id);

        public async Task AddMealAsync(Meal meal)
        {
            await context.AddAsync(meal);
            await context.SaveChangesAsync();
        }

        public async Task RemoveMealAsync(Meal meal)
        {
            context.Remove(meal);
            await context.SaveChangesAsync();
        }

        public async Task UpdateMealAsync(Meal meal)
        {
            context.Update(meal);
            await context.SaveChangesAsync();
        }
    }
}
