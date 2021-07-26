using System;
using System.Collections.Generic;
using System.Text;

namespace IbradnzMealBuilder.Core
{
    public class Meal:Entity
    {
        public MealType Carbohydrate { get; set; }
        public double CarbohydrateAmount { get; set; }
        public MealType Vegetable { get; set; }
        public double VegetableAmount { get; set; }
        public MealType Protein { get; set; }
        public double ProteinAmount { get; set; }
        public MealType Fat { get; set; }
        public double FatAmount { get; set; }
        public int CustomerId { get; set; }
        public MealBuilder MealBuilder { get; set; }
    }
}
