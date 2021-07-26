using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using IbradnzMealBuilder.Core;
using IbradnzMealBuilder.Models;
using IbradnzMealBuilder.Service.Contract;
using IbradnzMealBuilder.Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace IbradnzMealBuilder.Controllers
{
    [Authorize(Roles = AppConstant.CustomerRole)]
    public class TutorialController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly ICustomerService _customerService;
        private readonly IMealTypeService _mealTypeService;
        private readonly IMealBuilderService _mealBuilderService;
        private readonly IOptions<AppSettings> appSettings;

        public TutorialController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, ICustomerService customerService,
            IMealTypeService mealTypeService, IMealBuilderService mealBuilderService, IOptions<AppSettings> app)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _customerService = customerService;
            _mealTypeService = mealTypeService;
            _mealBuilderService = mealBuilderService;
            appSettings = app;
        }

        public IActionResult Index()
        {
            var customer = GetLoggedInCustomer();

            var allMealTypes = _mealTypeService.GetAllMealTypes();
            List<MealViewModel> mealViewModels = new List<MealViewModel>();
            double waterIntake = GeneralFunction.CalculateWaterIntake(customer.Weight, customer.Unit);
            int numberOfPlates = AppConstant.MinNumberOfPlates;
            for (int i = 0; i < numberOfPlates; i++)
                mealViewModels.Add(new MealViewModel(allMealTypes, numberOfPlates, customer));
            var mealBuilderViewModel = new TutorialModel(allMealTypes, mealViewModels, customer, AppConstant.CustomizeMeal);
            return View(mealBuilderViewModel);
        }

        public IActionResult Tutorial1()
        {
            var customer = GetLoggedInCustomer();

            var allMealTypes = _mealTypeService.GetAllMealTypes();
            List<MealViewModel> mealViewModels = new List<MealViewModel>();
            double waterIntake = GeneralFunction.CalculateWaterIntake(customer.Weight, customer.Unit);
            int numberOfPlates = AppConstant.MinNumberOfPlates;
            for (int i = 0; i < numberOfPlates; i++)
                mealViewModels.Add(new MealViewModel(allMealTypes, numberOfPlates, customer));
            var mealBuilderViewModel = new TutorialModel(allMealTypes, mealViewModels, customer, AppConstant.CustomizeMeal);
            return View(mealBuilderViewModel);
        }

        public IActionResult Tutorial2()
        {
            ViewBag.TodaysDate = GeneralFunction.ConvertDateToSpanish(DateTime.Now);
            return View();
        }

        public IActionResult Tutorial3()
        {
            var customer = GetLoggedInCustomer();

            var allMealTypes = _mealTypeService.GetAllMealTypes();
            List<MealViewModel> mealViewModels = new List<MealViewModel>();
            double waterIntake = GeneralFunction.CalculateWaterIntake(customer.Weight, customer.Unit);
            int numberOfPlates = AppConstant.MinNumberOfPlates;
            for (int i = 0; i < numberOfPlates; i++)
                mealViewModels.Add(new MealViewModel(allMealTypes, numberOfPlates, customer));
            var mealBuilderViewModel = new TutorialModel(allMealTypes, mealViewModels, customer, AppConstant.CustomizeMeal);
            return View(mealBuilderViewModel);
            //return RedirectToAction("Index", "Subscribe");
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
