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
    public class TutorialModel
    {
        public string CustomerName { get; set; }

        public string DateInSpanish { get; set; }
        public DateTime Date { get; set; }

        [Display(Name = "Tus calorías diarias para tu meta")]
        public double Calories { get; set; }

        [Required(ErrorMessage = "Required")]
        [Display(Name = "Tu agua del dia")]
        public double WaterIntake { get; set; }

        [Display(Name = "¿Cuántas comidas harás hoy?")]
        public int MealNumber { get; set; }

        [Range(1, 2)]
        [Display(Name = "¿Quieres personalizar cada una de tus comidas?")]
        public int Customize { get; set; }

        [Display(Name = "Macro protein")]
        public double MacrosProtein { get; set; }
        [Display(Name = "Macro carbohydrate")]
        public double MacrosCarbohydrate { get; set; }
        [Display(Name = "Macro fat")]
        public double MacroFat { get; set; }
        public bool IsUserSubscribed { get; set; }

        public List<SelectListItem> Carbohydrates { get; set; }
        public List<SelectListItem> Vegetables { get; set; }
        public List<SelectListItem> Proteins { get; set; }
        public List<SelectListItem> Fats { get; set; }

        public List<MealViewModel> Meals { get; set; }
        public TutorialModel() { }
        public TutorialModel(IEnumerable<MealType> mealtypes, List<MealViewModel> mealViewModels, Customer customer, int customize)
        {
            CustomerName = customer.Firstname;
            Date = DateTime.Now.Date;
            DateInSpanish = GeneralFunction.ConvertDateToSpanish(DateTime.Now);
            Meals = mealViewModels;
            WaterIntake = GeneralFunction.CalculateWaterIntake(customer.Weight, customer.Unit);
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

        //public void SetNutrientSelectItem(IEnumerable<MealType> allMealTypes)
        //{
        //    List<SelectListItem> carbohydrates = new List<SelectListItem>();
        //    List<SelectListItem> fats = new List<SelectListItem>();
        //    List<SelectListItem> proteins = new List<SelectListItem>();
        //    List<SelectListItem> vegetables = new List<SelectListItem>();

        //    foreach (var mealType in allMealTypes.Where(m => m.NutrientClass == NutrientClass.Carbohydrate))
        //        carbohydrates.Add(new SelectListItem { Text = mealType.Name, Value = mealType.Id.ToString() });

        //    foreach (var mealType in allMealTypes.Where(m => m.NutrientClass == NutrientClass.Fat))
        //        fats.Add(new SelectListItem { Text = mealType.Name, Value = mealType.Id.ToString() });

        //    foreach (var mealType in allMealTypes.Where(m => m.NutrientClass == NutrientClass.Protein))
        //        proteins.Add(new SelectListItem { Text = mealType.Name, Value = mealType.Id.ToString() });

        //    foreach (var mealType in allMealTypes.Where(m => m.NutrientClass == NutrientClass.Vegetables))
        //        vegetables.Add(new SelectListItem { Text = mealType.Name, Value = mealType.Id.ToString() });

        //    Proteins = proteins;
        //    Fats = fats;
        //    Carbohydrates = carbohydrates;
        //}

        //public MealBuilder Save(Customer customer)
        //{
        //    MealBuilder mealBuilder = new MealBuilder()
        //    {
        //        Customer = customer,
        //        WaterIntake = (decimal)WaterIntake,
        //        NumberOfMeals = MealNumber,
        //        Calories = customer.Calories,
        //        CustomizeMeal = Customize == 1 ? "Similar meals" : "Customize meals",
        //        DateScheduledFor = Date,
        //    };
        //    return mealBuilder;
        //}

        //public Meal GetMeal(int customerId, MealBuilder mealBuilder, MealType protein, double proteinAmt, MealType fat,
        //    double fatAmt, MealType carbohydrate, double carbsAmt)
        //{
        //    return new Meal()
        //    {
        //        Carbohydrate = carbohydrate,
        //        CarbohydrateAmount = carbsAmt,
        //        Protein = protein,
        //        ProteinAmount = proteinAmt,
        //        Vegetable = protein,
        //        VegetableAmount = proteinAmt,
        //        Fat = fat,
        //        FatAmount = fatAmt,
        //        CustomerId = customerId,
        //        MealBuilder = mealBuilder,
        //        DateCreated = DateTime.Now,
        //        DateCreatedUtc = DateTime.UtcNow,
        //        DateModified = DateTime.Now,
        //        DateModifiedUtc = DateTime.UtcNow,
        //        IsDeleted = false,
        //    };
        //}
    }
}
