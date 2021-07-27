using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using IbradnzMealBuilder.Models;
using IbradnzMealBuilder.Data;
using Microsoft.EntityFrameworkCore;
using IbradnzMealBuilder.Service.Contract;
using IbradnzMealBuilder.Core;
using Microsoft.AspNetCore.Identity;
using IbradnzMealBuilder.Utility;
using System.Security.Claims;
using Microsoft.Extensions.Options;
using System.Security.Principal;

namespace IbradnzMealBuilder.Controllers
{
    public class HomeController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly ICustomerService _customerService;
        private readonly IOptions<AppSettings> appSettings;
        private readonly ITrainingVideoService _subsc;
        private readonly ILiveZoomService _service;

        public HomeController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, ICustomerService customerService,
            ITrainingVideoService su, ILiveZoomService service, IOptions<AppSettings> app)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _customerService = customerService;
            _subsc = su;
            _service = service;
            appSettings = app;
        }

        public async Task<IActionResult> Index()
        {
           
            return View();
        }

        
        public IActionResult PremiumUsersOnly()
        {
            ViewBag.MonthlyPrice = appSettings.Value.MonthlySubscriptionPrice;
            ViewBag.YearlyPrice = appSettings.Value.YearlySubscriptionPrice;
            return PartialView("_PremiumUsersOnly");
        }

        public IActionResult LowProteinOption()
        {
            return PartialView("_LowProteinOption");
        }

        public IActionResult Font()
        {
            return View();
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public ApplicationUser GetLoggedInUser()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var user = _userManager.Users.Where(u => u.Id == userId).FirstOrDefault();
            return user;
        }
    }
}
