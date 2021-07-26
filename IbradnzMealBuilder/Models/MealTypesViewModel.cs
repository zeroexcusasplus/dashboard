using IbradnzMealBuilder.Core;
using IbradnzMealBuilder.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IbradnzMealBuilder.Models
{

    public class ViewMealTypesViewModel
    {
        public IEnumerable<MealTypeViewModel> CarbsMealTypes { get; set; }
        public IEnumerable<MealTypeViewModel> ProteinMealTypes { get; set; }
        public IEnumerable<MealTypeViewModel> FatMealTypes { get; set; }
        public IEnumerable<MealTypeViewModel> VegetableMealTypes { get; set; }
        public ViewMealTypesViewModel(IEnumerable<MealType> mealTypes)
        {
            CarbsMealTypes = GetMealTypes(mealTypes, NutrientClass.Carbohydrate);
            ProteinMealTypes = GetMealTypes(mealTypes, NutrientClass.Protein);
            FatMealTypes = GetMealTypes(mealTypes, NutrientClass.Fat);
            VegetableMealTypes = GetMealTypes(mealTypes, NutrientClass.Vegetables);
        }
        public IEnumerable<MealTypeViewModel> GetMealTypes(IEnumerable<MealType> mealTypes, NutrientClass nutrientClass)
        {
            IEnumerable<MealTypeViewModel> _mealTypes = mealTypes
                .Where(m=>m.NutrientClass == nutrientClass)
                .Select(m => new MealTypeViewModel()
                {
                    Id = m.Id,
                    Name = m.Name,
                    Nutrient = m.NutrientClass.ToString(),
                    UnitValue = m.UnitValue,
                    CarbsPerUnitGram = m.CarbsPerUnitGram,
                    ProteinPerUnitGram = m.ProteinPerUnitGram,
                    FatPerUnitGram = m.FatPerUnitGram,
                }) ;
            return _mealTypes;
        }
    }

    public class MealTypeViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Nutrient { get; set; }
        public double UnitValue { get; set; }
        public double CarbsPerUnitGram { get; set; }
        public double ProteinPerUnitGram { get; set; }
        public double FatPerUnitGram { get; set; }
    }

    public class AddMealTypeViewModel
    {
        [Required(ErrorMessage ="Required")]
        [BeginWIthAlphaNumeric(ErrorMessage ="Must begin with alphabeth or number")]
        public string Name { get; set; }
        public NutrientClass Nutrient { get; set; }


        [Required(ErrorMessage = "Required")]
        [Display(Name = "Unit value")]
        public double UnitValue { get; set; }

        [Required(ErrorMessage = "Required")]
        [Display(Name = "Carbs per unit gram")]
        public double CarbsPerUnitGram { get; set; }

        [Required(ErrorMessage = "Required")]
        [Display(Name = "Protein per unit gram")]
        public double ProteinPerUnitGram { get; set; }

        [Required(ErrorMessage = "Required")]
        [Display(Name = "Fat per unit gram")]
        public double FatPerUnitGram { get; set; }

        public MealType AddMealType(AddMealTypeViewModel mealTypeModel)
        {
            MealType mealType = new MealType()
            {
                Name = mealTypeModel.Name,
                NutrientClass = mealTypeModel.Nutrient,
                UnitValue = mealTypeModel.UnitValue,
                CarbsPerUnitGram = mealTypeModel.CarbsPerUnitGram,
                ProteinPerUnitGram = mealTypeModel.ProteinPerUnitGram,
                FatPerUnitGram = mealTypeModel.FatPerUnitGram,
            };
            return mealType;
        }
    }

    public class EditMealTypeViewModel
    {
        public int MealTypeId { get; set; }

        [Required(ErrorMessage = "Required")]
        [BeginWIthAlphaNumeric(ErrorMessage = "Must begin with alphabeth or number")]
        public string Name { get; set; }
        public NutrientClass Nutrient { get; set; }

        [Required(ErrorMessage = "Required")]
        [Display(Name="Unit value")]
        public double UnitValue { get; set; }

        [Required(ErrorMessage = "Required")]
        [Display(Name = "Carbs per unit gram")]
        public double CarbsPerUnitGram { get; set; }

        [Required(ErrorMessage = "Required")]
        [Display(Name = "Protein per unit gram")]
        public double ProteinPerUnitGram { get; set; }

        [Required(ErrorMessage = "Required")]
        [Display(Name = "Fat per unit gram")]
        public double FatPerUnitGram { get; set; }
        public EditMealTypeViewModel() {}
        public EditMealTypeViewModel(MealType mealType)
        {
            MealTypeId = mealType.Id;
            Name = mealType.Name;
            Nutrient = mealType.NutrientClass;
            UnitValue = mealType.UnitValue;
            ProteinPerUnitGram = mealType.ProteinPerUnitGram;
            CarbsPerUnitGram = mealType.CarbsPerUnitGram;
            FatPerUnitGram = mealType.FatPerUnitGram;
        }

        public MealType EditMealTypeMap(MealType mealType)
        {
            mealType.Name = Name;
            mealType.NutrientClass = Nutrient;
            mealType.UnitValue = UnitValue;
            mealType.CarbsPerUnitGram = CarbsPerUnitGram;
            mealType.ProteinPerUnitGram = ProteinPerUnitGram;
            mealType.FatPerUnitGram = FatPerUnitGram;
            return mealType;
        }
        
    }

}
