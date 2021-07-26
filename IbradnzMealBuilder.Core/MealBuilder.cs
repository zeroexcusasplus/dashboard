using System;
using System.Collections.Generic;
using System.Text;

namespace IbradnzMealBuilder.Core
{
    public class MealBuilder:Entity
    {
        public DateTime DateScheduledFor { get; set; }
        public Customer Customer { get; set; }
        public decimal WaterIntake { get; set; }
        public int NumberOfMeals { get; set; }
        public double Calories { get; set; }
        public IEnumerable<Meal> Meals { get; set; }
        public string CustomizeMeal { get; set; }
    }
}
