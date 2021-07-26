using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using IbradnzMealBuilder.Core;
using IbradnzMealBuilder.CustomFilters;
using IbradnzMealBuilder.Models;
using IbradnzMealBuilder.Service.Contract;
using IbradnzMealBuilder.Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Options;
using Rotativa.AspNetCore;

namespace IbradnzMealBuilder.Controllers
{
    [Authorize(Roles = AppConstant.CustomerRole)]
    public class MealsController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly ICustomerService _customerService;
        private readonly IMealTypeService _mealTypeService;
        private readonly IMealBuilderService _mealBuilderService;
        private readonly IOptions<AppSettings> appSettings;

        public MealsController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, ICustomerService customerService,
            IMealTypeService mealTypeService, IMealBuilderService mealBuilderService, IOptions<AppSettings> app)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _customerService = customerService;
            _mealTypeService = mealTypeService;
            _mealBuilderService = mealBuilderService;
            appSettings = app;
        }

        [CheckIfAccountSetupIsCompleteMealController]
        public async Task<IActionResult> MealBuilder()
        {
            var user = GetLoggedInUser();
            if (user != null)
            {
                if (await _userManager.IsInRoleAsync(user, AppConstant.AdminRole))
                    return RedirectToAction("Mealtypes", "Admin");
            }

            var customer = GetLoggedInCustomer();
            var allMealTypes = _mealTypeService.GetAllMealTypes();
            List<MealViewModel> mealViewModels = new List<MealViewModel>();
            double waterIntake = GeneralFunction.CalculateWaterIntake(customer.Weight,customer.Unit);
            int numberOfPlates = AppConstant.MinNumberOfPlates;
            for (int i = 0; i < numberOfPlates; i++)
                mealViewModels.Add(new MealViewModel(allMealTypes, numberOfPlates, customer));
            CreateMealBuilderViewModel mealBuilderViewModel = new CreateMealBuilderViewModel(allMealTypes,mealViewModels,customer,AppConstant.CustomizeMeal);
            return View(mealBuilderViewModel);
        }

        [HttpPost]
        [CheckIfAccountSetupIsCompleteMealController]
        [CheckSubscriptionMeals]
        public async Task<IActionResult> MealBuilder(CreateMealBuilderViewModel mealBuilderModel)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var customer = GetLoggedInCustomer();
            var mealBuilder = mealBuilderModel.Save(customer);
            List<Meal> meals = new List<Meal>();
            foreach(var meal in mealBuilderModel.Meals)
            {
                var carbohydrate = _mealTypeService.GetMealTypeById(mealBuilderModel.Customize == 2 ? meal.Carbohydrate : mealBuilderModel.Meals[0].Carbohydrate);
                var protein = _mealTypeService.GetMealTypeById(mealBuilderModel.Customize == 2 ? meal.Protein : mealBuilderModel.Meals[0].Protein);
                //var vegetable = _mealTypeService.GetMealTypeById(mealBuilderModel.Customize == 1 ? meal.Carbohydrate : mealBuilderModel.Meals[0].Carbohydrate);
                var fat = _mealTypeService.GetMealTypeById(mealBuilderModel.Customize == 2 ? meal.Fat : mealBuilderModel.Meals[0].Fat);
                meals.Add(mealBuilderModel.GetMeal(customer.Id, mealBuilder, protein, meal.ProteinAmount, fat, meal.FatAmount, carbohydrate, meal.CarbohydrateAmount));
            }
            mealBuilder.Meals = meals;

            await _mealBuilderService.AddMealBuilder(mealBuilder);
            return RedirectToAction(nameof(Details), new { id = mealBuilder.Id});
        }

        [CheckIfAccountSetupIsCompleteMealController]
        public IActionResult MealBuilderTable(int mealNumber = 0, int customize = 0, double ltrOfWater = 1, double macroCarbohydrate = 0,
            double macroProtein = 0, double macroFat = 0)
      {
            try
            {
                var customer = GetLoggedInCustomer();
                var allMealTypes = _mealTypeService.GetAllMealTypes();
                List<MealViewModel> mealViewModels = new List<MealViewModel>();

                for (int i = 1; i <= mealNumber; i++)
                {
                    if (DateTime.Compare(customer.SubscriptionExpiringDateUtc, DateTime.UtcNow) < 0)
                        mealViewModels.Add(new MealViewModel(allMealTypes, mealNumber, customer));
                    else
                        mealViewModels.Add(new MealViewModel(allMealTypes, mealNumber, customer, macroProtein, macroFat, macroCarbohydrate));
                }

                CreateMealBuilderViewModel mealBuilderModel = new CreateMealBuilderViewModel()
                {
                    Meals = mealViewModels,
                    Customize = customize,
                };
                mealBuilderModel.SetNutrientSelectItem(allMealTypes);
                return PartialView("_MealBuilderMealTable", mealBuilderModel);
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        [CheckIfAccountSetupIsCompleteMealController]
        public IActionResult CalculateMealAmount(int carbohydrateId, int proteinId, int fatId, double macrosCarbs, double macrosProtein, double macrosFat,int numberOfPlate)
        {
            var customer = GetLoggedInCustomer();
            var carbohydrate = _mealTypeService.GetMealTypeById(carbohydrateId);
            var carbsUnit = GeneralFunction.GetNutrientUnit(carbohydrate.Name);
            var protein = _mealTypeService.GetMealTypeById(proteinId);
            var proteinUnit = GeneralFunction.GetNutrientUnit(protein.Name);
            var fat = _mealTypeService.GetMealTypeById(fatId);
            var fatUnit = GeneralFunction.GetNutrientUnit(fat.Name);

            MealViewModel mealModel = new MealViewModel();
            if (DateTime.Compare(customer.SubscriptionExpiringDateUtc, DateTime.UtcNow) < 0)
                mealModel = new MealViewModel(carbohydrate, protein, fat, customer, numberOfPlate, customer.Goal);
            else
                mealModel = new MealViewModel(carbohydrate, protein, fat, macrosCarbs, macrosProtein, macrosFat, numberOfPlate, customer.Goal);

            return Json(new { success = true, carbs = mealModel.CarbohydrateAmount, carbsAndUnit = $"{mealModel.CarbohydrateAmount} {carbsUnit}",
                protein = mealModel.ProteinAmount, proteinAndUunit=$"{mealModel.ProteinAmount} {proteinUnit}",
                fat = mealModel.FatAmount, fatAndUnit = $"{mealModel.FatAmount} {fatUnit}" });
        }

        public IActionResult ChangeMacroNutrient(MacroNutrientRange macroNutrientRange)
        {
            return PartialView("_ChangeMacroNutrient", new MacroNutrientViewModel(macroNutrientRange));
        }

        public IActionResult ChangeMacroNutrientPost(int totalCalories, MacroNutrientRange macroNutrientRange)
        {
            double macrosProtein = GeneralFunction.CalculateMacroProtein(macroNutrientRange,totalCalories);
            double macrosFat = GeneralFunction.CalculateMacroFat(macroNutrientRange, totalCalories);
            double macrosCarbs = GeneralFunction.CalculateMacroCarbs(macroNutrientRange, totalCalories);

            return Json(new { success = true, macrosProtein = macrosProtein, macrosFat= macrosFat, macrosCarbs = macrosCarbs });
        }

        public IActionResult PremiumUsersOnly()
        {
            ViewBag.MonthlyPrice = appSettings.Value.MonthlySubscriptionPrice;
            ViewBag.YearlyPrice = appSettings.Value.YearlySubscriptionPrice;
            return PartialView("_PremiumUsersOnly");
        }

        public IActionResult ChangeDate(DateTime date, int moveDateBy)
        {
            var _date = date.AddDays(moveDateBy);
            var dateInString = GeneralFunction.ConvertDateToSpanish(_date);
            return Json(new { success = true, date = _date.Date.ToString("yyyy-MM-dd"), dateInSpanish = dateInString});
        }

        [CheckIfAccountSetupIsCompleteMealController]
        public IActionResult Details(int id)
        {
            try
            {

                var customer = GetLoggedInCustomer();
                var mealBuilder = _mealBuilderService.GetMealBuilderById(id);
                if (customer != mealBuilder.Customer)
                    return NotFound();

                var mealBuilderModel = new ViewMealBuilderAndMealsViewModel(mealBuilder);

                return View(mealBuilderModel);
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public IActionResult PdfDetails(int id)
        {
            try
            {
                var customer = GetLoggedInCustomer();
                var mealBuilder = _mealBuilderService.GetMealBuilderById(id);
                if (customer != mealBuilder.Customer)
                    return NotFound();

                var mealBuilderModel = new ViewMealBuilderAndMealsViewModel(mealBuilder);
                return new ViewAsPdf(mealBuilderModel);
            }
            catch (Exception ex)
            {

                throw;
            }
        }


        public ApplicationUser GetLoggedInUser()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var user = _userManager.Users.Where(u => u.Id == userId).FirstOrDefault();
            return user;
        }

        public Customer GetLoggedInCustomer()
        {
            var user = GetLoggedInUser();
            if (user == null)
                throw new Exception();
            return _customerService.GetCustomerByUserId(user.Id);
        }
    }
}