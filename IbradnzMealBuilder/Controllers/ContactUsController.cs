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
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace IbradnzMealBuilder.Controllers
{
    [Authorize(Roles =AppConstant.CustomerRole)]
    public class ContactUsController : Controller
    {
        private readonly IEmailSender _emailSender;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IOptions<AppSettings> appSettings;
        private readonly ICustomerService _customerService;

        public ContactUsController(IEmailSender emailSender, IOptions<AppSettings> app, UserManager<ApplicationUser> _userManager, ICustomerService customerService)
        {
            appSettings = app;
            this._userManager = _userManager;
            _customerService = customerService;
            _emailSender = emailSender;
        }

        public IActionResult Index()
        {
            var model = new ContactUsModel();
            model.MessageSent = TempData["MessageSent"] == null ? false : (bool)TempData["MessageSent"];
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Index(ContactUsModel model)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "Uno o más errores de validación");
                return View();
            }

            var user = GetLoggedInUser();
            string messageSumarry = $"Email from {user.Email} </br> {model.Message}";

            MailService mailService = new MailService(appSettings);
            await mailService.SendMail(appSettings.Value.ContactUsEmail, "Contact us email", messageSumarry,
                appSettings.Value.AppEmail, model.Affair);

            TempData["MessageSent"] = true;
            return RedirectToAction(nameof(Index));
        }


        public ApplicationUser GetLoggedInUser()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var user = _userManager.Users.Where(u => u.Id == userId).FirstOrDefault();
            return user;
        }

        private Customer GetLoggedInCustomer()
        {
            var user = GetLoggedInUser();
            if (user == null)
                throw new Exception();
            return _customerService.GetCustomerByUserId(user.Id);
        }

    }
}
