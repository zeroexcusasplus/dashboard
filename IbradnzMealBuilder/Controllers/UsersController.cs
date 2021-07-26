using IbradnzMealBuilder.Core;
using IbradnzMealBuilder.Models;
using IbradnzMealBuilder.Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IbradnzMealBuilder.Controllers
{
    [Authorize(Roles = AppConstant.AdminRole)]
    public class UsersController : Controller
    {
        private readonly UserManager<ApplicationUser> userManager;

        public UsersController(UserManager<ApplicationUser> userManager)
        {
            this.userManager = userManager;
        }

       
        public IActionResult index()
        {
            var users = userManager.Users;
            return View(users);
        }


      
    }
}
