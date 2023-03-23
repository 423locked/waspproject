using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.Models
{
    public class Meal
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [Required]
        [MaxLength(10)]
        public double Calories { get; set; }

        [Required]
        [MaxLength(10)]
        public double Proteins { get; set; }

        [Required]
        [MaxLength(10)]
        public double Carbohydrates { get; set; }

        [Required]
        [MaxLength(10)]
        public double Fats { get; set; }

        [Required]
        [MaxLength(10)]
        public double Weight { get; set; }

        [Required]
        [MaxLength(10)]
        public string Category { get; set; }

        [Required]        
        public string Description { get; set; }

        public Meal()
        {
            
        }

        public Meal(string name, double calories, double proteins, double carbs, double fats, double weight, string category)
        {
            Name = name;
            Calories = calories;
            Proteins = proteins;
            Carbohydrates = carbs; 
            Fats = fats;
            Weight = weight;
            Category = category;
            Description = $"C: {Calories}, P: {Proteins}, C: {Carbohydrates}, " +
                   $"F: {Fats}, Weight: {Weight}";
        }
    }
}
