using MauiApp1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace CalcountNew.Domain
{
    public static class JsonHelper
    {
        public static List<Meal> JsonStrToMeal(JObject json, string category)
        {
            List<Meal> res = new List<Meal>();
            foreach (var food in json["foods"])
                res.Add(new Meal
                {
                    Name = food["food_name"].ToString(),
                    Calories = Convert.ToDouble(food["nf_calories"].ToString()),
                    Fats = Convert.ToDouble(food["nf_total_fat"].ToString()),
                    Carbohydrates = Convert.ToDouble(food["nf_total_carbohydrate"].ToString()),
                    Proteins = Convert.ToDouble(food["nf_protein"].ToString()),
                    Category = category,
                    Weight = Convert.ToDouble(food["serving_qty"].ToString()) *
                       Convert.ToDouble(food["serving_weight_grams"].ToString())
                });
            foreach (Meal meal in res)
                meal.Description = $"Cals: {meal.Calories} P: {meal.Proteins} C: {meal.Carbohydrates} " +
                   $"F: {meal.Fats} Weight: {meal.Weight}";
            return res;
        }
    }
}
