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
using Newtonsoft.Json;
using Stripe;
using Stripe.Checkout;

namespace IbradnzMealBuilder.Controllers
{
    public class CreateCheckoutSessionRequest
    {
        [JsonProperty("priceId")]
        public string PriceId { get; set; }
    }

    [Authorize(Roles =AppConstant.CustomerRole)]
    [CheckIfAccountIsCompleteSubscribeController]
    public class SubscribeController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly ICustomerService _customerService;
        private readonly ISubscriptionService _subscriptionService;
        private readonly IOptions<AppSettings> appSettings;

        public SubscribeController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, ICustomerService customerService,
            ISubscriptionService subscriptionService, IOptions<AppSettings> app)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _customerService = customerService;
            _subscriptionService = subscriptionService;
            appSettings = app;
        }

        public IActionResult Index()
        {
            return View(new SubscriptionPlanModel(GetLoggedInCustomer()));
        }

        public IActionResult ChangePlan(SubscriptionPlan plan)
        {
            return PartialView("_SubPlanDetails", new SubscriptionPlanModel(plan));
        }

        //public IActionResult Pay(SubscriptionPlan plan)
        //{
        //    if (plan == SubscriptionPlan.Free)
        //        return RedirectToAction(nameof(Successful));
        //    PaymentModel paymentModel = new PaymentModel(plan);
        //    return View(paymentModel);
        //}
        public IActionResult Pay(SubscriptionPlan plan)
        {
            
            PaymentModel paymentModel = new PaymentModel(plan);
            return View(paymentModel);
        }

        [HttpPost]
        public async Task<IActionResult> Pay(PaymentModel paymentModel,string subscriptionPlan)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "Uno o más errores de validación");
                return View(paymentModel);
            }

            try
            {
               
                var message = "";
                if (paymentModel.SubscriptionPlan == SubscriptionPlan.Monthly && !string.IsNullOrEmpty(paymentModel.CouponCode) && paymentModel.CouponCode == "45643")
                {
                    paymentModel.Amount = appSettings.Value.MonthlyCouponSubscriptionPrice;
                    paymentModel.SubscriptionPlan = SubscriptionPlan.Monthly;
                }
               else if (paymentModel.SubscriptionPlan == SubscriptionPlan.Monthly)
                {
                    paymentModel.Amount = appSettings.Value.MonthlySubscriptionPrice;
                    paymentModel.SubscriptionPlan = SubscriptionPlan.Monthly;
                }

                else if (paymentModel.SubscriptionPlan == SubscriptionPlan.Yearly)
                {
                    paymentModel.Amount = appSettings.Value.YearlySubscriptionPrice;
                    paymentModel.SubscriptionPlan = SubscriptionPlan.Yearly;
                }
           
                else
                {
                    Console.WriteLine("No plane selected");
                }

                //else if (paymentModel.SubscriptionPlan == SubscriptionPlan.Free)
                //return RedirectToAction(nameof(Successful));

                int amountInCents = ((int)paymentModel.Amount * 100);
                message = await StripePayment.PayAsync(paymentModel, amountInCents);
                //message = "Success";
                var customer = GetLoggedInCustomer();
                if (message == "Success")
                {
                    try
                    {
                        Core.Subscription subscription = new Core.Subscription()
                        {
                            Name = paymentModel.Name,
                            Lastname = paymentModel.LastName,
                            ZipCode = paymentModel.ZipCode,
                            Amount = paymentModel.Amount,
                            UserId = customer.UserId,

                            Customer = customer,
                            SubscriptionPlan = paymentModel.SubscriptionPlan,
                            Expirydate = DateTime.Now.AddDays(30),
                        };
                        await _subscriptionService.AddSubscription(subscription,customer);
                        return RedirectToAction(nameof(Successful));
                    }
                    catch (Exception ex)
                    {
                        return RedirectToAction(nameof(Successful));
                        //throw;
                    }
                }
                else
                {
                    ModelState.AddModelError("", "Disculpa, tu pago fue declinado, intenta de nuevo");
                    ModelState.AddModelError("", message);
                    return View(paymentModel);
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }


        public async Task<ActionResult> CreateCheckoutSession([FromBody] CreateCheckoutSessionRequest req)
        {
            var options = new SessionCreateOptions
            {
                // See https://stripe.com/docs/api/checkout/sessions/create
                // for additional parameters to pass.
                // {CHECKOUT_SESSION_ID} is a string literal; do not change it!
                // the actual Session ID is returned in the query parameter when your customer
                // is redirected to the success page.
                SuccessUrl = "https://example.com/success.html?session_id={CHECKOUT_SESSION_ID}",
                CancelUrl = "https://example.com/canceled.html",
                PaymentMethodTypes = new List<string>
                {
                    "card",
                },
                Mode = "subscription",
                LineItems = new List<SessionLineItemOptions>
                {
                    new SessionLineItemOptions
                    {
                    Price = req.PriceId,
                    
                    // For metered billing, do not pass quantity
                    Quantity = 1,
                    },
                },
            };

            try
            {
                var service = new SessionService();
                var session = await service.CreateAsync(options);

                return Json(new { sessionId = session.Id });
            }
            catch (StripeException e)
            {
                Console.WriteLine(e.StripeError.Message);
                return Content("");
                //return BadRequest(new ErrorResponse
                //{
                //    ErrorMessage = new ErrorMessage
                //    {
                //        Message = e.StripeError.Message,
                //    }
                //});
            }
        }


        public IActionResult Expired()
        {
            return View();
        }

        public IActionResult Successful()
        {
            var customer = GetLoggedInCustomer();
            ViewBag.CustomerName = customer.Firstname;
            ViewBag.TodaysDate = GeneralFunction.ConvertDateToSpanish(DateTime.Now);
            return View();
        }

        private List<SelectListItem> GetSubscriptionPlans(string selectedSubscription="")
        {
            List<SelectListItem> subscriptionPlans = new List<SelectListItem>();
            subscriptionPlans.Add(
                new SelectListItem
                {
                    Text = $"Yearly ${appSettings.Value.YearlySubscriptionPrice}/Year",
                    Value = "Yearly",
                    Selected = selectedSubscription=="Yearly" ? true : false,
                });

            subscriptionPlans.Add(
                new SelectListItem
                {
                    Text = $"Monthly ${appSettings.Value.MonthlySubscriptionPrice}/Month",
                    Value = "Monthly",
                    Selected = selectedSubscription == "Monthly" ? true : false,
                });


            subscriptionPlans.Add(
                new SelectListItem
                {
                    Text = $"Monthly ${appSettings.Value.MonthlyCouponSubscriptionPrice}/Month",
                    Value = "Monthly",
                    Selected = selectedSubscription == "Monthly" ? true : false,
                });
            return subscriptionPlans;

        }

        public ApplicationUser GetLoggedInUser()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var user = _userManager.Users.Where(u => u.Id == userId).ToList().FirstOrDefault();
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