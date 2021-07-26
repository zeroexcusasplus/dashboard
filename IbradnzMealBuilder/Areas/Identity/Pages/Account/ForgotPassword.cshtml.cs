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
using IbradnzMealBuilder.Utility;
using Microsoft.Extensions.Options;
using System.Net;

namespace IbradnzMealBuilder.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class ForgotPasswordModel : PageModel
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IEmailSender _emailSender;
        private readonly IOptions<AppSettings> appSettings;

        public ForgotPasswordModel(UserManager<ApplicationUser> userManager, IEmailSender emailSender, IOptions<AppSettings> app)
        {
            _userManager = userManager;
            _emailSender = emailSender;
            appSettings = app;
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public class InputModel
        {
            [Required(ErrorMessage = "Correo electronico es requerido")]
            [EmailAddress(ErrorMessage = "Dirección de correo electrónico inválida")]
            [Display(Name = "Correo Electronico")]
            public string Email { get; set; }
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (ModelState.IsValid)
            {
                try
                {

                    var user = await _userManager.FindByEmailAsync(Input.Email);
                    if (user == null/* || !(await _userManager.IsEmailConfirmedAsync(user))*/)
                    {
                        // Don't reveal that the user does not exist or is not confirmed
                        return RedirectToPage("./ForgotPasswordConfirmation");
                    }

                    // For more information on how to enable account confirmation and password reset please 
                    // visit https://go.microsoft.com/fwlink/?LinkID=532713
                    var code = await _userManager.GeneratePasswordResetTokenAsync(user);
                    var callbackUrl = Url.Page(
                        "/Account/ResetPassword",
                        pageHandler: null,
                        values: new { code },
                        protocol: Request.Scheme);

                    string messageSumarry = $"Please reset your password by <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>clicking here</a>.";

                    MailService mailService = new MailService(appSettings);
                    await mailService.SendMail(Input.Email, "Reset password", messageSumarry,
                        appSettings.Value.AppEmail, "Password reset");

                    //await _emailSender.SendEmailAsync(
                    //    Input.Email,
                    //    "Reset Password",
                    //    $"Please reset your password by <a href='{HtmlEncoder.Default.Encode(callbackUrl)}'>clicking here</a>.");

                    return RedirectToPage("./ForgotPasswordConfirmation");
                }
                catch (Exception ex)
                {

                    throw;
                }

            }

            return Page();
        }
    }
}
