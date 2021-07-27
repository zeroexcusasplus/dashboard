using IbradnzMealBuilder.Core;
using IbradnzMealBuilder.Models;
using IbradnzMealBuilder.Service.Contract;
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
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ICustomerService _customerService;

        public UsersController(UserManager<ApplicationUser> userManager, ICustomerService customerService)
        {
            this._userManager = userManager;
            this._customerService = customerService;
        }

       
        public IActionResult index()
        {
            var users = _userManager.Users;
            return View(users);
        }

        public IActionResult GetAllCustomer()
        {
            var customers = _customerService.GetAllCustomers();
            return View(customers);
        }



    }
}
