using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using IbradnzMealBuilder.Core;
using IbradnzMealBuilder.CustomFilters;
using IbradnzMealBuilder.Models;
using IbradnzMealBuilder.Service.Contract;
using IbradnzMealBuilder.Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using RestSharp;
using Stripe;

namespace IbradnzMealBuilder.Controllers
{
    [Authorize(Roles =AppConstant.CustomerRole)]
    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<ApplicationRole> _roleManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly ICustomerService _customerService;
        private readonly IMealBuilderService _mealBuilderService;
        private readonly ISubscriptionService _subscritpionService;
        private readonly IProfileImageService _profileImageService;
        private readonly ICountryPhoneCodeService _countryCodeService;
        private readonly IEmailSender _emailSender;
        private readonly IOptions<AppSettings> appSettings;
        public IEnumerable<SubscriptionModel> _Subscriptions { get; set; }
        public AccountController(UserManager<ApplicationUser> userManager,SignInManager<ApplicationUser> signInManager, RoleManager<ApplicationRole> roleManager, ICustomerService customerService, IMealBuilderService mealBuilderService, ISubscriptionService subscriptionService, IProfileImageService profileImageService,
            ICountryPhoneCodeService countryCodeService, IEmailSender emailSender, IOptions<AppSettings> app, IEnumerable<SubscriptionModel> subscriptions)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
            _customerService = customerService;
            _mealBuilderService = mealBuilderService;
            _subscritpionService = subscriptionService;
            _profileImageService = profileImageService;
            _countryCodeService = countryCodeService;
            _emailSender = emailSender;
            appSettings = app;
            _Subscriptions = subscriptions;
        }

        [CheckIfAccountSetupIsComplete]
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Details()
        {
            try
            {


                var customer = GetLoggedInCustomer();
                var user = GetLoggedInUser();
                
                var accountDetails = new AccountDetailsViewModel(customer, user.Email);

                
                return View(accountDetails);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        [HttpPost]
        [CheckIfAccountSetupIsComplete]
        public async Task<IActionResult> Details(AccountDetailsViewModel model)
        {
            //var client = new RestClient("https://api.stripe.com/v1/subscriptions/sub_JmMBBS79HhdRcc?key=sk_test_51HLWNwAydFIsMiHPnCXWWj4LEcNZ9yvpPrYuNo7CH0vcktny2InKuihs5LapLDgdQBYmIXwcC92e25HHqYUYPlc900syJsguGt");
            //client.Timeout = -1;
            //var request = new RestRequest(Method.GET);
            //IRestResponse response = client.Execute(request);
            //Console.WriteLine(response.Content);

            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "Uno o más errores de validación");
                return View(model);
            }

            var user = GetLoggedInUser();
            if (user == null)
                return RedirectToAction(nameof(Details));

            var changePasswordResult = await _userManager.ChangePasswordAsync(user, model.OldPassword, model.NewPassword);
            if (!changePasswordResult.Succeeded)
            {
                foreach (var error in changePasswordResult.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
                return View(model);
            }

            await _signInManager.RefreshSignInAsync(user);
            return RedirectToAction(nameof(Details));
        }

        [CheckIfAccountSetupIsComplete]
        public IActionResult Profile()
        {
            try
            {
                var customer = GetLoggedInCustomer();
                var user = GetLoggedInUser();
               
                
                var profileImages = _profileImageService.GetAllForCustomer(customer.Id);
                ProfileViewModel profileModel = new ProfileViewModel(customer,user.Email,profileImages);
                
                return View(profileModel);
            }
            catch (Exception  ex)
            {
                throw;
            }
        }

        [AllowAnonymous]
        public IActionResult SetupProfile()
        {
            var customerProfile = TempData["CustomerDetails"] == null
                        ? null 
                        : JsonConvert.DeserializeObject<SetupProfileViewModel>(TempData["CustomerDetails"].ToString());
            customerProfile = customerProfile == null ? new SetupProfileViewModel() : customerProfile;
            customerProfile.SetCountryCodeSelect(_countryCodeService);
            return View(customerProfile == null ? new SetupProfileViewModel() : customerProfile);
        }

        [AllowAnonymous]
        [HttpPost]
        public IActionResult SetupProfile(SetupProfileViewModel profileModel)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "Uno o más errores de validación");
                return View(profileModel);
            }
            //var customer = profileModel.NewCustomer();
            TempData["CustomerDetails"] = JsonConvert.SerializeObject(profileModel);

            return RedirectToAction(nameof(SetupGoalAndActivity));

        }

        [AllowAnonymous]
        public IActionResult ReturnToSetupProfile(string customer)
        {
            TempData["CustomerDetails"] = customer;
            return RedirectToAction(nameof(SetupProfile));
        }

        [AllowAnonymous]
        public IActionResult SetupGoalAndActivity()
        {
            if (TempData["CustomerDetails"] == null)
                return RedirectToAction(nameof(SetupProfile));
            var customerProfile = JsonConvert.DeserializeObject<SetupProfileViewModel>(TempData["CustomerDetails"].ToString());
            customerProfile.CustomerInString = TempData["CustomerDetails"].ToString();
            customerProfile.Email = "";
            customerProfile.Password = "";
            return View(customerProfile);
        }

        [AllowAnonymous]
        [HttpPost]
        public  async Task<IActionResult> SetupGoalAndActivity(SetupProfileViewModel model)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "Uno o más errores de validación");
                return View(model);
            }

            var user = new ApplicationUser { UserName = model.Email, Email = model.Email, IsAccountSetUpComplete = false };
            var result = await _userManager.CreateAsync(user, model.Password);
            if (result.Succeeded)
            {
                if (await _roleManager.FindByNameAsync(AppConstant.CustomerRole) == null)
                    await _roleManager.CreateAsync(new ApplicationRole(AppConstant.CustomerRole));
                await _userManager.AddToRoleAsync(user, AppConstant.CustomerRole);

                var customer = model.NewCustomer(user.Id);
                try
                {
                    await _customerService.AddCustomer(customer, user);
                    await _signInManager.SignInAsync(user, isPersistent: false);
                    return RedirectToAction("Index", "Tutorial");

                }
                catch (Exception ex)
                {
                    await _userManager.DeleteAsync(user);
                    ModelState.AddModelError("", "Uno o más errores de validación");
                }
            }
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError(string.Empty, error.Description);
            }
            return View(model);
        }


        [CheckIfAccountSetupIsComplete]
        public IActionResult EditProfile()
        {
            var customer = GetLoggedInCustomer();
            EditProfileViewModel profileModel = new EditProfileViewModel();
            profileModel = profileModel.GetProfileModel(customer);
            return View(profileModel);
        }

        [CheckIfAccountSetupIsComplete]
        [HttpPost]
        public async Task<IActionResult> EditProfile(EditProfileViewModel profileModel)
        {
            if (!ModelState.IsValid)
            {
                profileModel.PrevUnit = profileModel.Unit;
                ModelState.AddModelError("", "Uno o más errores de validación");
                return View(profileModel);
            }
            var user = GetLoggedInUser();
            var customer = _customerService.GetCustomerById(profileModel.CustomerId);
            if (customer != GetLoggedInCustomer())
                throw new Exception();

            customer = profileModel.EditCustomerProfileModel(customer);
            await _customerService.EditCustomer(customer,user);

            return RedirectToAction(nameof(Profile));
        }

        [CheckIfAccountSetupIsComplete]
        public IActionResult Meals()
        {
            var customer = GetLoggedInCustomer();
            var mealBuilders = _mealBuilderService.GetMealBuildersForCustomer(customer.Id);
            IEnumerable<MealBuilderViewModel> mealBuilderModels = mealBuilders
                .Select(m => new MealBuilderViewModel()
                {
                    Id = m.Id,
                    DateCreated = m.DateScheduledFor,
                    DateCreatedstring = GeneralFunction.ConvertDateToSpanish(m.DateScheduledFor),
                    MealNumber = m.NumberOfMeals,
                    WaterIntake = m.WaterIntake.ToString(),
                }).ToList();

            return View(mealBuilderModels);
        }

        [CheckIfAccountSetupIsComplete]
        public IActionResult ViewMeal(int id)
        {
            var customer = GetLoggedInCustomer();
            var mealBuilder = _mealBuilderService.GetMealBuilderById(id);
            if (customer != mealBuilder.Customer)
                throw new Exception();

            ViewMealBuilderAndMealsViewModel mealBuilderModel = new ViewMealBuilderAndMealsViewModel(mealBuilder);
            return View(mealBuilderModel);
        }
        
        //[CheckIfAccountSetupIsComplete]
        //public IActionResult ProfileImages()
        //{
        //    var customer = GetLoggedInCustomer();
        //    var profileImages = _profileImageService.GetAllForCustomer(customer.Id);
        //    var profileImageModel = new ProfileImageViewModel(profileImages);
        //    return View(profileImageModel);
        //}

        //[HttpPost]
        //[CheckIfAccountSetupIsComplete]
        //public async Task<IActionResult> ProfileImages(ProfileImageViewModel profileModel)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        ModelState.AddModelError("", "Uno o más errores de validación");
        //        var _customer = GetLoggedInCustomer();
        //        var _profileImages = _profileImageService.GetAllForCustomer(_customer.Id);
        //        var profileImageModel = new ProfileImageViewModel(_profileImages);
        //        return View(profileImageModel);
        //    }

        //    foreach (var imageProfile in profileModel.ProfileImages)
        //    {
        //        var ext = Path.GetExtension(imageProfile.FileName);
        //        if (!FileService.CheckIfFileIsImage(ext))
        //        {
        //            var _customer = GetLoggedInCustomer();
        //            var _profileImages = _profileImageService.GetAllForCustomer(_customer.Id);
        //            var profileImageModel = new ProfileImageViewModel(_profileImages);
        //            return View(profileImageModel);
        //        }
        //    }
        //    var customer = GetLoggedInCustomer();
        //    var profileImages = new List<ProfileImage>();
        //    foreach (var imageProfile in profileModel.ProfileImages)
        //    {
        //        string imagePath = "";
        //        imagePath = await FileService.SaveDoc(imageProfile, "ProfileImages", FileService.FileType.Image);
        //        profileImages.Add(profileModel.AddProfileImage(imagePath,customer));
        //    }

        //    await _profileImageService.AddRange(profileImages);
        //    return RedirectToAction(nameof(ProfileImages));
        //}

        //public async Task<IActionResult> DeleteProfileImage(int id)
        //{
        //    var profileImage = _profileImageService.Get(id);

        //    var customer = GetLoggedInCustomer();
        //    if (profileImage.CustomerId != customer.Id)
        //        throw new Exception();

        //    await _profileImageService.Delete(profileImage);
        //    var profileImages = _profileImageService.GetAllForCustomer(customer.Id);
        //    var profileImageModel = new ProfileImageViewModel(profileImages);

        //    return PartialView("_ProfileImages", profileImageModel);
        //}

        [CheckIfAccountSetupIsComplete]
        public IActionResult Subscriptions()
        {
            var customer = GetLoggedInCustomer();
            var subscriptions = _subscritpionService.GetAllCustomerSubscriptions(customer);
            IEnumerable<SubscriptionModel> subscriptionModels = subscriptions
                .Select(subscription => new SubscriptionModel()
                {
                    Id = subscription.Id,
                    DateCreated = subscription.DateCreatedUtc,
                    DateTimeCreatedString = subscription.DateCreatedUtc.ToString("dd/MMM/yyyy hh:mm tt") + " GMT",
                    SubscriptionPlan = subscription.SubscriptionPlan.ToString(),
                    Amount = "$"+ subscription.Amount.ToString(),
                    
                }).OrderByDescending(s=> s.DateCreated);
            ViewSubscriptionsViewModel viewSubscriptionModels = new ViewSubscriptionsViewModel(subscriptionModels, customer.DateCreatedUtc);

            return View(viewSubscriptionModels);
        }

        public async Task<IActionResult> ForgotPassword()
        {
            try
            {

                var user = GetLoggedInUser();
                var code = await _userManager.GeneratePasswordResetTokenAsync(user);
                var callbackUrl = Url.Page(
                    "/Account/ResetPassword",
                    pageHandler: null,
                    values: new { area = "Identity", code = code },
                    protocol: Request.Scheme);

                string messageSumarry = $"Please reset your password by <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>clicking here</a>.";

                MailService mailService = new MailService(appSettings);
                await mailService.SendMail(user.Email, "Reset password", messageSumarry,
                    appSettings.Value.AppEmail, "Password reset");
                return Json(new { success = true });
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        //[CheckIfAccountSetupIsComplete]
        //public async Task<IActionResult> ChangePassword()
        //{
        //    ApplicationUser user = GetLoggedInUser();
        //    if (user == null)
        //    {
        //        return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
        //    }

        //    var hasPassword = await _userManager.HasPasswordAsync(user);
        //    if (!hasPassword)
        //    {
        //        return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
        //    }

        //    return View();
        //}

       

        public ApplicationUser GetLoggedInUser()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var user = _userManager.Users.Where(u => u.Id == userId).FirstOrDefault();
            return user;
        }

        private Core.Customer GetLoggedInCustomer()
        {
            var user = GetLoggedInUser();
            if (user == null)
                throw new Exception();
            return _customerService.GetCustomerByUserId(user.Id);
        }
    }
}

