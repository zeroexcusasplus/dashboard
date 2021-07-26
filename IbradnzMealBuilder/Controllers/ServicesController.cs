using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IbradnzMealBuilder.Utility;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace IbradnzMealBuilder.Controllers
{
    public class ServicesController : Controller
    {
        private readonly IOptions<AppSettings> appSettings;
        public ServicesController(IOptions<AppSettings> app)
        {
            appSettings = app;
        }
        public IActionResult Index()
        {
            return RedirectToAction("Index", "Subscribe");
            ViewBag.Monthly = appSettings.Value.MonthlySubscriptionPrice;
            ViewBag.Yearly = appSettings.Value.YearlySubscriptionPrice;
            return View();
        }
    }
}
