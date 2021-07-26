using IbradnzMealBuilder.Core;
using IbradnzMealBuilder.Utility;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IbradnzMealBuilder.Models
{
    public class CreateMealBuilderViewModel
    {
        public string DateInSpanish { get; set; }
        public DateTime Date { get; set; }

        [Display(Name = "Tus calorías diarias para tu meta")]
        public double Calories { get; set; }

        [Required(ErrorMessage ="Required")]
        [Display(Name = "Tu agua del dia")]
        public double WaterIntake { get; set; }

        [Display(Name = "¿Cuántas comidas harás hoy?")]
        public int MealNumber { get; set; }

        [Range(1,2)]
        [Display(Name = "¿Quieres personalizar cada una de tus comidas?")]
        public int Customize { get; set; }

        [Display(Name ="Macro protein")]
        public double MacrosProtein { get; set; }
        [Display(Name ="Macro carbohydrate")]
        public double MacrosCarbohydrate { get; set; }
        [Display(Name ="Macro fat")]
        public double MacroFat { get; set; }
        public bool IsUserSubscribed { get; set; }

        public List<SelectListItem> Carbohydrates { get; set; }
        public List<SelectListItem> Vegetables { get; set; }
        public List<SelectListItem> Proteins { get; set; }
        public List<SelectListItem> Fats { get; set; }

        public List<MealViewModel> Meals { get; set; }
        public CreateMealBuilderViewModel() {}
        public CreateMealBuilderViewModel(IEnumerable<MealType> mealtypes, List<MealViewModel> mealViewModels,Customer customer,int customize)
        {
            Date = DateTime.Now.Date;
            DateInSpanish = GeneralFunction.ConvertDateToSpanish(DateTime.Now);
            Meals = mealViewModels;
            WaterIntake = GeneralFunction.CalculateWaterIntake(customer.Weight,customer.Unit);
            Calories = customer.Calories;
            MacrosProtein = GeneralFunction.CalculateMacroProtein(customer.Weight, customer.Calories, customer.Goal, customer.Unit);
            MacroFat = GeneralFunction.CalculateMacroFat(customer.Calories, customer.Goal);
            MacrosCarbohydrate = GeneralFunction.CalculateMacroCarbohydrate(customer.Calories, MacrosProtein, MacroFat);
            if (DateTime.Compare(customer.SubscriptionExpiringDateUtc, DateTime.UtcNow) < 0)
                IsUserSubscribed = false;
            else
                IsUserSubscribed = true;


            List<SelectListItem> carbohydrates = new List<SelectListItem>();
            List<SelectListItem> fats = new List<SelectListItem>();
            List<SelectListItem> proteins = new List<SelectListItem>();
            List<SelectListItem> vegetables = new List<SelectListItem>();

            foreach (var mealType in mealtypes.Where(m => m.NutrientClass == NutrientClass.Carbohydrate))
                carbohydrates.Add(new SelectListItem { Text = mealType.Name, Value = mealType.Id.ToString() });

            foreach (var mealType in mealtypes.Where(m => m.NutrientClass == NutrientClass.Fat))
                fats.Add(new SelectListItem { Text = mealType.Name, Value = mealType.Id.ToString() });

            foreach (var mealType in mealtypes.Where(m => m.NutrientClass == NutrientClass.Protein))
                proteins.Add(new SelectListItem { Text = mealType.Name, Value = mealType.Id.ToString() });

            foreach (var mealType in mealtypes.Where(m => m.NutrientClass == NutrientClass.Vegetables))
                vegetables.Add(new SelectListItem { Text = mealType.Name, Value = mealType.Id.ToString() });

            Proteins = proteins;
            Fats = fats;
            Carbohydrates = carbohydrates;
            Customize = customize;
        }
       
        public void SetNutrientSelectItem(IEnumerable<MealType> allMealTypes)
        {
            List<SelectListItem> carbohydrates = new List<SelectListItem>();
            List<SelectListItem> fats = new List<SelectListItem>();
            List<SelectListItem> proteins = new List<SelectListItem>();
            List<SelectListItem> vegetables = new List<SelectListItem>();

            foreach (var mealType in allMealTypes.Where(m => m.NutrientClass == NutrientClass.Carbohydrate))
                carbohydrates.Add(new SelectListItem { Text = mealType.Name, Value = mealType.Id.ToString() });

            foreach (var mealType in allMealTypes.Where(m => m.NutrientClass == NutrientClass.Fat))
                fats.Add(new SelectListItem { Text = mealType.Name, Value = mealType.Id.ToString() });

            foreach (var mealType in allMealTypes.Where(m => m.NutrientClass == NutrientClass.Protein))
                proteins.Add(new SelectListItem { Text = mealType.Name, Value = mealType.Id.ToString() });

            foreach (var mealType in allMealTypes.Where(m => m.NutrientClass == NutrientClass.Vegetables))
                vegetables.Add(new SelectListItem { Text = mealType.Name, Value = mealType.Id.ToString() });

            Proteins = proteins;
            Fats = fats;
            Carbohydrates = carbohydrates;
        }

        public MealBuilder Save(Customer customer)
        {
            MealBuilder mealBuilder = new MealBuilder()
            {
                Customer = customer,
                WaterIntake = (decimal)WaterIntake,
                NumberOfMeals = MealNumber,
                Calories = customer.Calories,
                CustomizeMeal = Customize == 1 ? "Similar meals" : "Customize meals",
                DateScheduledFor = Date,
            };
            return mealBuilder;
        }

        public Meal GetMeal(int customerId,MealBuilder mealBuilder,MealType protein, double proteinAmt, MealType fat, 
            double fatAmt, MealType carbohydrate, double carbsAmt)
        {
            return new Meal()
            {
                Carbohydrate = carbohydrate,
                CarbohydrateAmount = carbsAmt,
                Protein = protein,
                ProteinAmount = proteinAmt,
                Vegetable = protein,
                VegetableAmount = proteinAmt,
                Fat = fat,
                FatAmount = fatAmt,
                CustomerId = customerId,
                MealBuilder = mealBuilder,
                DateCreated = DateTime.Now,
                DateCreatedUtc = DateTime.UtcNow,
                DateModified = DateTime.Now,
                DateModifiedUtc = DateTime.UtcNow,
                IsDeleted = false,
                
            };
        }
    }

    public class MealBuilderViewModel
    {
        public int Id { get; set; }
        public DateTime DateCreated { get; set; }
        public string DateCreatedstring { get; set; }
        public int MealNumber { get; set; }
        public string WaterIntake { get; set; }

        public bool isCompleted { get; set; }
    }

    
    public class MealViewModel
    {
        public int Carbohydrate { get; set; }
        public double CarbohydrateAmount { get; set; }
        public string CarbohydrateAmtAndUnit { get; set; }

        public int Vegetable { get; set; }
        public double VegetableAmount { get; set; }

        public int Protein { get; set; }
        public double ProteinAmount { get; set; }
        public string ProteinAmtAndUnit { get; set; }

        public int Fat { get; set; }
        public double FatAmount { get; set; }
        public string FatAmtAndUnit { get; set; }
        public bool isCompleted { get; set; }
        public MealViewModel() {}

        public MealViewModel(IEnumerable<MealType> mealtypes,int numberOfPlates,Customer customer)
        {
            double proteinPerPlate = GeneralFunction.RoundUp(customer.MacrosProtein / numberOfPlates,0);
            double carbsPerPlate = GeneralFunction.RoundUp(customer.MacrosCarbohydrate / numberOfPlates, 0);
            double fatPerPlate = GeneralFunction.RoundUp(customer.MacrosFat / numberOfPlates, 0);

            var firstProtein = mealtypes.Where(m => m.NutrientClass == NutrientClass.Protein).First();
            var firstCarbohydrate = mealtypes.Where(m => m.NutrientClass == NutrientClass.Carbohydrate).First();
            var firstFat = mealtypes.Where(m => m.NutrientClass == NutrientClass.Fat).First();

            double gramOfProtein = GeneralFunction.CalculateGramOfProtein(proteinPerPlate, firstProtein.UnitValue, firstProtein.ProteinPerUnitGram);
            double remainingFatFromProtein = GeneralFunction.CalculateRemainingFatFromProtein(gramOfProtein, firstProtein.FatPerUnitGram, firstProtein.UnitValue, fatPerPlate);
            double remainingCarbsFromProtein = GeneralFunction.CalculateRemainingCarbsFromProtein(gramOfProtein, firstProtein.CarbsPerUnitGram, firstProtein.UnitValue, carbsPerPlate);
            double gramOfFat = GeneralFunction.CalculateGramOfFat(remainingFatFromProtein, firstFat.UnitValue, firstFat.FatPerUnitGram);
            double remainingCarbsFromFat = GeneralFunction.CalculateRemainingCarbsFromFat(gramOfFat, firstFat.CarbsPerUnitGram, firstFat.UnitValue, remainingCarbsFromProtein);
            double gramOfCarbs = GeneralFunction.CalculateGramOfCarbs(remainingCarbsFromFat, firstCarbohydrate.UnitValue, firstCarbohydrate.CarbsPerUnitGram);

            CarbohydrateAmount = gramOfCarbs;
            ProteinAmount = gramOfProtein;
            FatAmount = gramOfFat;

            CarbohydrateAmtAndUnit = GeneralFunction.GetNutrientUnit(firstCarbohydrate.Name);
            ProteinAmtAndUnit = GeneralFunction.GetNutrientUnit(firstProtein.Name);
            FatAmtAndUnit = GeneralFunction.GetNutrientUnit(firstFat.Name);

            VegetableAmount = GeneralFunction.CalculateGramOfVegetable(customer.Goal);

        }

        public MealViewModel(IEnumerable<MealType> mealtypes, int numberOfPlates, Customer customer,
            double macroProtein, double macroFat, double macroCarbs)
        {
            double proteinPerPlate = GeneralFunction.RoundUp(macroProtein / numberOfPlates, 0);
            double carbsPerPlate = GeneralFunction.RoundUp(macroCarbs / numberOfPlates, 0);
            double fatPerPlate = GeneralFunction.RoundUp(macroFat / numberOfPlates, 0);

            var firstProtein = mealtypes.Where(m => m.NutrientClass == NutrientClass.Protein).First();
            var firstCarbohydrate = mealtypes.Where(m => m.NutrientClass == NutrientClass.Carbohydrate).First();
            var firstFat = mealtypes.Where(m => m.NutrientClass == NutrientClass.Fat).First();

            double gramOfProtein = GeneralFunction.CalculateGramOfProtein(proteinPerPlate, firstProtein.UnitValue, firstProtein.ProteinPerUnitGram);
            double remainingFatFromProtein = GeneralFunction.CalculateRemainingFatFromProtein(gramOfProtein, firstProtein.FatPerUnitGram, firstProtein.UnitValue, fatPerPlate);
            double remainingCarbsFromProtein = GeneralFunction.CalculateRemainingCarbsFromProtein(gramOfProtein, firstProtein.CarbsPerUnitGram, firstProtein.UnitValue, carbsPerPlate);
            double gramOfFat = GeneralFunction.CalculateGramOfFat(remainingFatFromProtein, firstFat.UnitValue, firstFat.FatPerUnitGram);
            double remainingCarbsFromFat = GeneralFunction.CalculateRemainingCarbsFromFat(gramOfFat, firstFat.CarbsPerUnitGram, firstFat.UnitValue, remainingCarbsFromProtein);
            double gramOfCarbs = GeneralFunction.CalculateGramOfCarbs(remainingCarbsFromFat, firstCarbohydrate.UnitValue, firstCarbohydrate.CarbsPerUnitGram);
            bool complete = isCompleted;

            CarbohydrateAmount = gramOfCarbs;
            ProteinAmount = gramOfProtein;
            FatAmount = gramOfFat;

            CarbohydrateAmtAndUnit = GeneralFunction.GetNutrientUnit(firstCarbohydrate.Name);
            ProteinAmtAndUnit = GeneralFunction.GetNutrientUnit(firstProtein.Name);
            FatAmtAndUnit = GeneralFunction.GetNutrientUnit(firstFat.Name);
            VegetableAmount = GeneralFunction.CalculateGramOfVegetable(customer.Goal);

        }


        public MealViewModel(MealType carbohydrate, MealType protein, MealType fat,double macrosCarbs, double macrosProtein, double macrosFat, int numberOfPlates,Goal goal)
        {
            double proteinPerPlate = GeneralFunction.RoundUp(macrosProtein / numberOfPlates, 0);
            double carbsPerPlate = GeneralFunction.RoundUp(macrosCarbs / numberOfPlates, 0);
            double fatPerPlate = GeneralFunction.RoundUp(macrosFat / numberOfPlates, 0);

            double gramOfProtein = GeneralFunction.CalculateGramOfProtein(proteinPerPlate, protein.UnitValue, protein.ProteinPerUnitGram);
            double remainingFatFromProtein = GeneralFunction.CalculateRemainingFatFromProtein(gramOfProtein, protein.FatPerUnitGram, protein.UnitValue, fatPerPlate);
            double remainingCarbsFromProtein = GeneralFunction.CalculateRemainingCarbsFromProtein(gramOfProtein, protein.CarbsPerUnitGram, protein.UnitValue, carbsPerPlate);
            double gramOfFat = GeneralFunction.CalculateGramOfFat(remainingFatFromProtein, fat.UnitValue, fat.FatPerUnitGram);
            double remainingCarbsFromFat = GeneralFunction.CalculateRemainingCarbsFromFat(gramOfFat, fat.CarbsPerUnitGram, fat.UnitValue, remainingCarbsFromProtein);
            double gramOfCarbs = GeneralFunction.CalculateGramOfCarbs(remainingCarbsFromFat, carbohydrate.UnitValue, carbohydrate.CarbsPerUnitGram);
            
            CarbohydrateAmount = gramOfCarbs;
            ProteinAmount = gramOfProtein;
            FatAmount = gramOfFat;

            CarbohydrateAmtAndUnit = GeneralFunction.GetNutrientUnit(carbohydrate.Name);
            ProteinAmtAndUnit = GeneralFunction.GetNutrientUnit(protein.Name);
            FatAmtAndUnit = GeneralFunction.GetNutrientUnit(fat.Name);
            VegetableAmount = GeneralFunction.CalculateGramOfVegetable(goal);
        }

        public MealViewModel(MealType carbohydrate, MealType protein, MealType fat, Customer customer, int numberOfPlates, Goal goal)
        {
            double proteinPerPlate = GeneralFunction.RoundUp(customer.MacrosProtein / numberOfPlates, 0);
            double carbsPerPlate = GeneralFunction.RoundUp(customer.MacrosCarbohydrate / numberOfPlates, 0);
            double fatPerPlate = GeneralFunction.RoundUp(customer.MacrosFat / numberOfPlates, 0);

            double gramOfProtein = GeneralFunction.CalculateGramOfProtein(proteinPerPlate, protein.UnitValue, protein.ProteinPerUnitGram);
            double remainingFatFromProtein = GeneralFunction.CalculateRemainingFatFromProtein(gramOfProtein, protein.FatPerUnitGram, protein.UnitValue, fatPerPlate);
            double remainingCarbsFromProtein = GeneralFunction.CalculateRemainingCarbsFromProtein(gramOfProtein, protein.CarbsPerUnitGram, protein.UnitValue, carbsPerPlate);
            double gramOfFat = GeneralFunction.CalculateGramOfFat(remainingFatFromProtein, fat.UnitValue, fat.FatPerUnitGram);
            double remainingCarbsFromFat = GeneralFunction.CalculateRemainingCarbsFromFat(gramOfFat, fat.CarbsPerUnitGram, fat.UnitValue, remainingCarbsFromProtein);
            double gramOfCarbs = GeneralFunction.CalculateGramOfCarbs(remainingCarbsFromFat, carbohydrate.UnitValue, carbohydrate.CarbsPerUnitGram);

            CarbohydrateAmount = gramOfCarbs;
            ProteinAmount = gramOfProtein;
            FatAmount = gramOfFat;

            CarbohydrateAmtAndUnit = GeneralFunction.GetNutrientUnit(carbohydrate.Name);
            ProteinAmtAndUnit = GeneralFunction.GetNutrientUnit(protein.Name);
            FatAmtAndUnit = GeneralFunction.GetNutrientUnit(fat.Name);
            VegetableAmount = GeneralFunction.CalculateGramOfVegetable(goal);
        }

     
    }

    public class ViewMealViewModel
    {
        public string Carbohydrate { get; set; }
        public string CarbohydrateAmount { get; set; }
        public string Vegetable { get; set; }
        public string VegetableAmount { get; set; }
        public string Protein { get; set; }
        public string ProteinAmount { get; set; }
        public string Fat { get; set; }
        public string FatAmount { get; set; }

        public ViewMealViewModel(Meal m)
        {
            Carbohydrate = m.Carbohydrate.Name;
            CarbohydrateAmount = m.CarbohydrateAmount.ToString();
            Protein = m.Protein.Name;
            ProteinAmount = m.ProteinAmount.ToString();
            Vegetable = m.Vegetable.Name;
            VegetableAmount = m.VegetableAmount.ToString();
            Fat = m.Fat.Name;
            FatAmount = m.FatAmount.ToString();
        }
    }

    public class ViewMealBuilderAndMealsViewModel
    {

        public int Id { get; set; }
        public string DateInString { get; set; }
        public IEnumerable<ViewMealViewModel> Meals { get; set; }
        public string WaterIntake { get; set; }
        public string MealNumber { get; set; }

        public ViewMealBuilderAndMealsViewModel(MealBuilder meal)
        {
            Id = meal.Id;
            MealNumber = meal.NumberOfMeals.ToString();
            WaterIntake = meal.WaterIntake.ToString();
            DateInString = GeneralFunction.ConvertDateToSpanish(meal.DateScheduledFor);
            Meals = meal.Meals.Select(m => new ViewMealViewModel(m)).ToList();
        }
    }
}
