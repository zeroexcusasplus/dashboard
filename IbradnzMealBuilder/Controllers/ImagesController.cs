using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using IbradnzMealBuilder.Core;
using IbradnzMealBuilder.Models;
using IbradnzMealBuilder.Service.Contract;
using IbradnzMealBuilder.Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace IbradnzMealBuilder.Controllers
{
    [Authorize(Roles =AppConstant.CustomerRole)]
    public class ImagesController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly ICustomerService _customerService;
        private readonly IProfileImageService _profileImageService;

        public ImagesController(UserManager<ApplicationUser> userManager, ICustomerService customerService, IProfileImageService profileImageService)
        {
            _userManager = userManager;
            _customerService = customerService;
            _profileImageService = profileImageService;
        }

        public IActionResult Index()
        {
            var images = _profileImageService.GetAllForCustomer(GetLoggedInCustomer().Id);
            var model = new CustomerImageViewModel(images.Select(img => new ViewProfileImageViewModel(img)));
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Index(CustomerImageViewModel model)
        {
            var customer = GetLoggedInCustomer();
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "Uno o más errores de validación");
                model.Images = _profileImageService.GetAllForCustomer(customer.Id)
                    .Select(img => new ViewProfileImageViewModel(img));
                return View(model);
            }

            foreach(var image in model.AddImage.Images)
            {
                var ext = Path.GetExtension(image.FileName);
                if (!FileService.CheckIfFileIsImage(ext))
                {
                    ModelState.AddModelError("", "Formato de archivo inválido");
                    model.Images = _profileImageService.GetAllForCustomer(customer.Id)
                                .Select(img => new ViewProfileImageViewModel(img));
                    return View(model);
                }
            }

            var profileImages = new List<ProfileImage>();
            foreach (var imageProfile in model.AddImage.Images)
            {
                string imagePath = "";
                imagePath = await FileService.SaveDoc(imageProfile, "ProfileImages", FileService.FileType.Image);
                profileImages.Add(model.AddImage.AddImage(imagePath, customer));
            }

            await _profileImageService.AddRange(profileImages);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> DeleteImage(int id)
        {
            var image = _profileImageService.Get(id);
            var customer = GetLoggedInCustomer();
            if (customer.Id != image.CustomerId)
                return Json(new { success=true });
            else
            {
                await _profileImageService.Delete(image);
                return Json(new { success = true });
            }

        }

        //[CheckIfAccountSetupIsComplete]
        //public async Task<IActionResult> ProfileImages(ProfileImageViewModel profileModel)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        ModelState.AddModelError("", "Uno o más errores de validación");
        //        var _customer = GetLoggedInCustomer();
        //        var _profileImages = _profileImageService.GetAllForCustomer(_customer.Id);
        //        var profileImageModel = new ProfileImageViewModel(_profileImages);
        //        return View(profileImageModel);
        //    }

        //    foreach (var imageProfile in profileModel.ProfileImages)
        //    {
        //        var ext = Path.GetExtension(imageProfile.FileName);
        //        if (!FileService.CheckIfFileIsImage(ext))
        //        {
        //            var _customer = GetLoggedInCustomer();
        //            var _profileImages = _profileImageService.GetAllForCustomer(_customer.Id);
        //            var profileImageModel = new ProfileImageViewModel(_profileImages);
        //            return View(profileImageModel);
        //        }
        //    }

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
