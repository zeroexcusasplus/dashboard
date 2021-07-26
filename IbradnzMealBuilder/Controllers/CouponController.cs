using IbradnzMealBuilder.Models;
using Microsoft.AspNetCore.Mvc;
using Stripe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IbradnzMealBuilder.Controllers
{
    public class CouponController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CouponAdd(CouponModel couponModel)
        {
            StripeConfiguration.ApiKey = "sk_test_51HLWNwAydFIsMiHPnCXWWj4LEcNZ9yvpPrYuNo7CH0vcktny2InKuihs5LapLDgdQBYmIXwcC92e25HHqYUYPlc900syJsguGt";

            var options = new CouponCreateOptions
            {
                 
                PercentOff = 20,
                Duration = "once",
            };
            var service = new CouponService();
            _ = service.Create(options);
            return View();
        }
    }
}
