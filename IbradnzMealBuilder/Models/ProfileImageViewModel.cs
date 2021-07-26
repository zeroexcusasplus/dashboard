using IbradnzMealBuilder.Core;
using IbradnzMealBuilder.Utility;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IbradnzMealBuilder.Models
{
    public class CustomerImageViewModel
    {
        public IEnumerable<ViewProfileImageViewModel> Images { get; set; }
        public AddProfileImageViewModel AddImage { get; set; }
        public CustomerImageViewModel(IEnumerable<ViewProfileImageViewModel> images)
        {
            Images = images;
        }
        public CustomerImageViewModel()
        {

        }
    }

    public class ViewProfileImageViewModel
    {
        public int Id { get; set; }
        public string ProfileUrl { get; set; }
        public string Weight { get; set; }
        public string DateInString { get; set; }
        public DateTime Date { get; set; }
        public ViewProfileImageViewModel(ProfileImage profileImage)
        {
            Id = profileImage.Id;
            ProfileUrl = GeneralFunction.GetUrlPath(profileImage.ImageUrl);
            Weight = profileImage.Weight.ToString();
            DateInString = GeneralFunction.ConvertDateToSpanish(profileImage.ImageDate);// profileImage.ImageDate.ToString("MMM/dd/yyyy");
            Date = profileImage.ImageDate;
        }
    }

    public class AddProfileImageViewModel
    {
        [Required(ErrorMessage = "se requiere peso")]
        [Display(Name ="Peso Actual")]
        public double Weight { get; set; }

        [Display(Name ="Fecha")]
        [Required(ErrorMessage = "la fecha de la imagen es obligatoria")]
        [DataType(DataType.Date)]
        public DateTime ImageDate { get; set; }
        public IEnumerable<IFormFile> Images { get; set; }
        public bool isTrue { get { return true; } }

        [Compare("isTrue", ErrorMessage = "Debe aceptar los términos antes de enviar")]
        public bool AgreeToTerms { get; set; }

        public ProfileImage AddImage(string url, Customer customer)
        {
            return new ProfileImage
            {
                Weight = Weight,
                ImageDate = ImageDate,
                ImageUrl = url,
                Customer = customer,
            };
        }
    }

    public class ProfileImageViewModel
    {
        [Display(Name = "Agregar nuevas imágenes")]
        public IEnumerable<IFormFile> ProfileImages { get; set; }
        public IEnumerable<ViewProfileImageViewModel> Images { get; set; }
        public ProfileImageViewModel() { }
        public ProfileImageViewModel(IEnumerable<ProfileImage> profileImages)
        {
            Images = profileImages
                .Select(p => new ViewProfileImageViewModel(p));
        }

        public ProfileImage AddProfileImage(string url, Customer customer)
        {
            return new ProfileImage()
            {
                ImageUrl = url,
                Customer = customer,
            };
        }

    }
}
