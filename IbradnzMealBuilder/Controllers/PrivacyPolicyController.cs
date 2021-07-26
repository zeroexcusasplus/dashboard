using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace IbradnzMealBuilder.Controllers
{
    public class PrivacyPolicyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
