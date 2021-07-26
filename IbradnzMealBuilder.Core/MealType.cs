using IbradnzMealBuilder.Utility;
using System;
using System.Collections.Generic;
using System.Text;

namespace IbradnzMealBuilder.Core
{
    public class MealType:Entity
    {
        public string Name { get; set; }
        public NutrientClass NutrientClass { get; set; }
        public double UnitValue { get; set; }
        public double CarbsPerUnitGram { get; set; }
        public double ProteinPerUnitGram { get; set; }
        public double FatPerUnitGram { get; set; }
    }
}
