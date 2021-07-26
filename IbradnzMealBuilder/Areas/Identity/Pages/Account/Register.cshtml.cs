using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using IbradnzMealBuilder.Core;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using IbradnzMealBuilder.Utility;
using IbradnzMealBuilder.Service.Contract;

namespace IbradnzMealBuilder.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class RegisterModel : PageModel
    {
        private readonly RoleManager<ApplicationRole> _roleManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ILogger<RegisterModel> _logger;
        private readonly IEmailSender _emailSender;
        private readonly ICustomerService _customerService;

        public RegisterModel(
            RoleManager<ApplicationRole> roleManager,
            UserManager<ApplicationUser> userManager,
            SignInManager<ApplicationUser> signInManager,
            ILogger<RegisterModel> logger,
            IEmailSender emailSender, ICustomerService customerService)
        {
            _roleManager = roleManager;
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
            _emailSender = emailSender;
            _customerService = customerService;
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public string ReturnUrl { get; set; }

        public class InputModel
        {

            [Required(ErrorMessage = "Correo electronico es requerido")]
            [EmailAddress(ErrorMessage = "Dirección de correo electrónico inválida")]
            [Display(Name = "Correo Electronico")]
            public string Email { get; set; }

            [Display(Name = "Contraseña")]
            [Required(ErrorMessage = "Se requiere contraseña")]
            [StringLength(100, ErrorMessage = "La contraseña debe tener {2} caracteres y no más de {1}.", MinimumLength = 6)]
            [DataType(DataType.Password)]
            public string Password { get; set; }

            [DataType(DataType.Password)]
            [Display(Name = "Confirmar contraseña")]
            [Compare("Password", ErrorMessage = "La contraseña y la contraseña de confirmación no coinciden")]
            public string ConfirmPassword { get; set; }
        }

        public IActionResult OnGet(string returnUrl = null)
        {
            ReturnUrl = returnUrl;
            return RedirectToAction("SetupProfile", "Account");
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            return RedirectToAction("SetupProfile", "Account");
            returnUrl = returnUrl ?? Url.Content("~/");
            if (ModelState.IsValid)
            {
                var user = new ApplicationUser { UserName = Input.Email, Email = Input.Email, IsAccountSetUpComplete = false };
                var result = await _userManager.CreateAsync(user, Input.Password);
                if (result.Succeeded)
                {
                    if (await _roleManager.FindByNameAsync(AppConstant.CustomerRole) == null)
                        await _roleManager.CreateAsync(new ApplicationRole(AppConstant.CustomerRole));

                    await _userManager.AddToRoleAsync(user, AppConstant.CustomerRole);
                    try
                    {
                        //await _customerService.AddNewCustomerFromRegister(user);
                    }
                    catch (Exception)
                    {
                        await _userManager.DeleteAsync(user);
                    }


                    _logger.LogInformation("User created a new account with password.");

                    var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                    var callbackUrl = Url.Page(
                        "/Account/ConfirmEmail",
                        pageHandler: null,
                        values: new { userId = user.Id, code = code },
                        protocol: Request.Scheme);

                    await _emailSender.SendEmailAsync(Input.Email, "Confirm your email",
                        $"Please confirm your account by <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>clicking here</a>.");

                    await _signInManager.SignInAsync(user, isPersistent: false);
                    return RedirectToAction("Setupprofile", "Account");
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
            }

            // If we got this far, something failed, redisplay form
            return Page();
        }
    }
}
