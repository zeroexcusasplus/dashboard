using IbradnzMealBuilder.Core;
using IbradnzMealBuilder.Service.Contract;
using IbradnzMealBuilder.Utility;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IbradnzMealBuilder.Models
{
    public class SetupProfileViewModel
    {
        [Required(ErrorMessage = "Se requiere nombre")]
        [RegularExpression("^[a-zA-Z0-9].*$", ErrorMessage = "El nombre completo debe comenzar con alfanumérico")]
        [Display(Name = "Nombre")]
        public string Firstname { get; set; }

        [Display(Name = "Apellido")]
        public string Lastname { get; set; }

        [Display(Name = "Sexo")]
        public Gender Gender { get; set; }

        [Required(ErrorMessage = "Se requiere Fecha de Nacimiento")]
        [Display(Name = "Fecha de Nacimiento (Mes/Día/Año)")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        [Range(1,int.MaxValue,ErrorMessage ="Select year")]
        public int DateOfBirthYear { get; set; }

        [Range(1,12,ErrorMessage ="Select month")]
        public int DateOfBirthMonth { get; set; }

        [Range(1,31,ErrorMessage ="Select day")]
        public int DateOfBirthDay { get; set; }

        [Display(Name = "País")]
        [Required(ErrorMessage = "Se requiere País")]
        public string Country { get; set; }

        [Display(Name = "Número de teléfono")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Se requiere Unidades")]
        [Display(Name = "Unidades")]
        public Unit Unit { get; set; }

        [Range(0.01,int.MaxValue,ErrorMessage = "La altura debe ser superior a 0.01")]
        [Required(ErrorMessage = "Se requiere Altura")]
        [Display(Name = "Altura")]
        public double Height { get; set; }

        [Required(ErrorMessage = "Se requiere Altura")]
        public double HeightInFeet { get; set; }

        public double HeightInches { get; set; }

        [Range(0.01, int.MaxValue,ErrorMessage = "El peso debe ser superior a 0.01")]
        [Required(ErrorMessage = "Se requiere Peso")]
        [Display(Name = "Peso")]
        public double Weight { get; set; }

        [Display(Name = "Selecciona tu nivel de actividad física diario")]
        public ActivityLevel ActivityLevel { get; set; }

        [Display(Name = "Escoge tu meta actual")]
        public Goal Goal { get; set; }
        public string CustomerInString { get; set; }

        public IEnumerable<IFormFile> ProfileImages { get; set; }

        public double BMR { get; set; }
        public double BMR_IncludingActivity { get; set; }
        public double DailyCalorieIntake { get; set; }
        public double MacroCarbohydrate { get; set; }
        public double MacroProtein { get; set; }
        public double MacroFat { get; set; }
        public double Calories { get; set; }

        [Required(ErrorMessage = "Correo electronico es requerido")]
        [EmailAddress(ErrorMessage = "Dirección de correo electrónico inválida")]
        [Display(Name = "Correo Electrónico")]
        public string Email { get; set; }

        [Display(Name = "Contraseña")]
        [Required(ErrorMessage = "Se requiere contraseña")]
        [StringLength(100, ErrorMessage = "La contraseña debe tener {2} caracteres y no más de {1}.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public IEnumerable<ViewCountryPhoneCodeModel> CountryPhoneModel { get; set; }
        public string SelectedCountryCode { get; set; }

        public void SetCountryCodeSelect(ICountryPhoneCodeService _countryCodeService)
        {
            CountryPhoneModel = _countryCodeService.GetAll().Select(c => new ViewCountryPhoneCodeModel(c))
                .OrderBy(c => c.Name);
            var selectedCountry = CountryPhoneModel.Where(c => c.Code == SelectedCountryCode).FirstOrDefault();
            if (selectedCountry != null)
            {
                selectedCountry.Selected = true;
            }
            else
            {
                SelectedCountryCode = CountryPhoneModel.FirstOrDefault().Code;
            }
        }

        public SetupProfileViewModel() {}

        public SetupProfileViewModel(Customer customer,string customerInString="") {
            Firstname = customer.Firstname;
            Lastname = customer.Lastname;
            Gender = customer.Gender;
            PhoneNumber = customer.PhoneNumber;
            Country = customer.Country;
            Unit = customer.Unit;
            Weight = customer.Weight;
            Height = customer.Height;
            ActivityLevel = customer.ActivityLevel;
            Goal = customer.Goal;
            DateOfBirth = customer.DateOfBirth;
            DateOfBirthDay = customer.DateOfBirth.Day;
            DateOfBirthMonth = customer.DateOfBirth.Month;
            DateOfBirthYear = customer.DateOfBirth.Year;
            CustomerInString = customerInString;
        }
       
        public Customer NewCustomer(string userId)
        {
            Height = Unit == Unit.Kgs ? Height : HeightInFeet + (HeightInches / (double)12);
            var customerDateOfBirth = new DateTime(DateOfBirthYear, DateOfBirthMonth, DateOfBirthDay);
            BMR = GeneralFunction.CalculateBMR(Gender, Unit, Weight, Height, customerDateOfBirth);
            BMR_IncludingActivity = GeneralFunction.CalculateBMR_IncludingActivityLevel(BMR, ActivityLevel);
            DailyCalorieIntake = GeneralFunction.CalculateDailyCalorieIntake(BMR_IncludingActivity, Goal);
            Calories = GeneralFunction.CalculateCalorieForGender(Gender, DailyCalorieIntake);
            MacroProtein = GeneralFunction.CalculateMacroProtein(Weight, DailyCalorieIntake, Goal, Unit);
            MacroFat = GeneralFunction.CalculateMacroFat(DailyCalorieIntake, Goal);
            MacroCarbohydrate = GeneralFunction.CalculateMacroCarbohydrate(Calories, MacroProtein, MacroFat);

            return new Customer
            {
                UserId = userId,
                Firstname = Firstname,
                Lastname = Lastname,
                Country = Country,
                PhoneNumber = PhoneNumber,
                Gender = Gender,
                Unit = Unit,
                Height = Height,
                Weight = Weight,
                DateOfBirth = new DateTime(DateOfBirthYear, DateOfBirthMonth, DateOfBirthDay),
                ActivityLevel = ActivityLevel,
                Goal = Goal,
                BMR = BMR,
                BMR_IncludingActivity = BMR_IncludingActivity,
                DailyCalorieIntake = DailyCalorieIntake,
                Calories = Calories,
                MacrosCarbohydrate = MacroCarbohydrate,
                MacrosFat = MacroFat,
                MacrosProtein = MacroProtein,
            };
        }

        public Customer SetupProfileModel(Customer customer,ApplicationUser user)
        {
            customer.DateOfBirth = new DateTime(DateOfBirthYear, DateOfBirthMonth, DateOfBirthDay);
            ActivityLevel = ActivityLevel;
            Goal = Goal;
            BMR = GeneralFunction.CalculateBMR(Gender, Unit, Weight, Height, customer.DateOfBirth);
            BMR_IncludingActivity = GeneralFunction.CalculateBMR_IncludingActivityLevel(BMR, ActivityLevel);
            DailyCalorieIntake = GeneralFunction.CalculateDailyCalorieIntake(BMR_IncludingActivity, Goal);
            Calories = GeneralFunction.CalculateCalorieForGender(Gender, DailyCalorieIntake);
            MacroProtein = GeneralFunction.CalculateMacroProtein(Weight, DailyCalorieIntake, Goal, Unit);
            MacroFat = GeneralFunction.CalculateMacroFat(DailyCalorieIntake, Goal);
            MacroCarbohydrate = GeneralFunction.CalculateMacroCarbohydrate(Calories, MacroProtein, MacroFat);

            customer.Firstname = Firstname;
            customer.Lastname = Lastname;
            customer.Country = Country;
            customer.Gender = Gender;
            customer.Height = Height;
            customer.Weight = Weight;
            customer.ActivityLevel = ActivityLevel;
            customer.Unit = Unit;
            customer.Goal = Goal;
            customer.BMR = BMR;
            customer.BMR_IncludingActivity = BMR_IncludingActivity;
            customer.DailyCalorieIntake = DailyCalorieIntake;
            customer.Calories = Calories;
            customer.MacrosCarbohydrate = MacroCarbohydrate;
            customer.MacrosFat = MacroFat;
            customer.MacrosProtein = MacroProtein;
            customer.PhoneNumber = PhoneNumber;
            return customer;
        }

        public ProfileImage AddProfileImage(string url)
        {
            return new ProfileImage()
            {
                DateCreated = DateTime.Now,
                DateCreatedUtc = DateTime.Now,
                DateModified = DateTime.Now,
                DateModifiedUtc = DateTime.Now,
                IsDeleted = false,
                ImageUrl = url,
            };
        }
    }

    public class ProfileViewModel
    {
        private string amount;

        [Display(Name = "Correo Electronico")]
        public string Email { get; set; }
        [Display(Name = "Tipo de miembro")]
        public string Membership { get; set; }
        public int CustomerId { get; set; }

        [Display(Name = "Nombre")]
        public string Firstname { get; set; }

        [Display(Name = "Apellido")]
        public string Lastname { get; set; }

        [Display(Name = "Sexo")]
        public string Gender { get; set; }

        [Display(Name = "País")]
        public string Country { get; set; }

        [Display(Name = "Número de teléfono")]
        public string PhoneNumber { get; set; }

        [Display(Name = "Fecha de Nacimiento")]
        public string DateOfBirth { get; set; }
        [Display(Name = "Unidades")]
        public string unit { get; set; }
        [Display(Name = "Altura")]
        public double Height { get; set; }
        [Display(Name = "Peso")]
        public double Weight { get; set; }
        [Display(Name = "Nivel de Actividad")]
        public string ActivityLevel { get; set; }
        [Display(Name = "Escoge tu Meta")]
        public string Goal { get; set; }
        [Display(Name ="BMR")]
        public double BMR { get; set; }
        [Display(Name = "BMR Including Activity level")]
        public double BMR_IncludingActivity { get; set; }
        [Display(Name = "Daily calorie intake")]
        public double DailyCalorieIntake { get; set; }
        [Display(Name = "Calories")]
        public double Calories { get; set; }
        public IEnumerable<ViewProfileImageViewModel> Images { get; set; }
        public ProfileViewModel(Customer customer, string email, IEnumerable<ProfileImage> profileImages)
        {
            PhoneNumber = customer.PhoneNumber;
            Membership = "None";
            Email = email;
            CustomerId = customer.Id;
            Firstname = customer.Firstname;
            Lastname = customer.Lastname;
            Country = customer.Country;
            Gender = EnumExtensions.GetDisplayName(customer.Gender);
            DateOfBirth = customer.DateOfBirth.ToString("MM/dd/yyyy");
            unit = EnumExtensions.GetDisplayName(customer.Unit);
            Height = customer.Height;
            Weight = customer.Weight;
            ActivityLevel = EnumExtensions.GetDisplayName(customer.ActivityLevel);
            Goal = EnumExtensions.GetDisplayName(customer.Goal);
            BMR = customer.BMR;
            BMR_IncludingActivity = customer.BMR_IncludingActivity;
            DailyCalorieIntake = customer.DailyCalorieIntake;
            Calories = customer.Calories;
            Images = profileImages
               .Select(p => new ViewProfileImageViewModel(p));
        }

        public ProfileViewModel(Customer customer, string email, IEnumerable<ProfileImage> profileImages, string amount) : this(customer, email, profileImages)
        {
            this.amount = amount;
        }
    }

    public class EditProfileViewModel 
    {
        public int CustomerId { get; set; }

        [Required(ErrorMessage = "Se requiere nombre")]
        [RegularExpression("^[a-zA-Z0-9].*$", ErrorMessage = "El nombre completo debe comenzar con alfanumérico")]
        [Display(Name = "Nombre")]
        public string Firstname { get; set; }

        [Display(Name = "Apellido")]
        public string Lastname { get; set; }

        [Display(Name = "País")]
        [Required(ErrorMessage = "Se requiere País")]
        [RegularExpression("^[a-zA-Z].*$", ErrorMessage = "La País debe comenzar con alphabeth")]
        public string Country { get; set; }

        [Display(Name = "Número de teléfono")]
        public string PhoneNumber { get; set; }

        [Display(Name = "Se requiere Sexo")]
        public Gender Gender { get; set; }

        [Required(ErrorMessage = "Se requiere Fecha de Nacimiento")]
        [Display(Name = "Fecha de Nacimiento")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "Select year")]
        public int DateOfBirthYear { get; set; }

        [Range(1, 12, ErrorMessage = "Select month")]
        public int DateOfBirthMonth { get; set; }

        [Range(1, 31, ErrorMessage = "Select day")]
        public int DateOfBirthDay { get; set; }

        [Required(ErrorMessage = "Se requiere Unidades")]
        [Display(Name = "Unidades")]
        public Unit Unit { get; set; }
        public Unit PrevUnit { get; set; }

        [Range(0.01, int.MaxValue, ErrorMessage = "La altura debe ser superior a 0.01")]
        [Required(ErrorMessage = "Se requiere Altura")]
        [Display(Name = "Altura")]
        public double Height { get; set; }

        [Range(0.01, int.MaxValue, ErrorMessage = "El peso debe ser superior a 0.01")]
        [Required(ErrorMessage = "Se requiere Peso")]
        [Display(Name = "Peso")]
        public double Weight { get; set; }

        [Display(Name = "Nivel de Actividad")]
        public ActivityLevel ActivityLevel { get; set; }

        [Display(Name = "Escoge tu Meta")]
        public Goal Goal { get; set; }
        public double BMR { get; set; }
        public double BMR_IncludingActivity { get; set; }
        public double DailyCalorieIntake { get; set; }
        public double MacroCarbohydrate { get; set; }
        public double MacroProtein { get; set; }
        public double MacroFat { get; set; }
        public double Calories { get; set; }

        public EditProfileViewModel GetProfileModel(Customer customer)
        {
            EditProfileViewModel profileModel = new EditProfileViewModel()
            {
                CustomerId = customer.Id,
                Firstname = customer.Firstname,
                Lastname = customer.Lastname,
                Country = customer.Country,
                DateOfBirth = customer.DateOfBirth,
                Gender = customer.Gender,
                Height = customer.Height,
                Weight = customer.Weight,
                ActivityLevel = customer.ActivityLevel,
                Unit = customer.Unit,
                PrevUnit = customer.Unit,
                Goal = customer.Goal,
                DateOfBirthDay = customer.DateOfBirth.Day,
                DateOfBirthMonth = customer.DateOfBirth.Month,
                DateOfBirthYear = customer.DateOfBirth.Year,
                PhoneNumber = customer.PhoneNumber,
            };
            return profileModel;
        }

        public Customer EditCustomerProfileModel(Customer customer)
        {
            customer.DateOfBirth = new DateTime(DateOfBirthYear, DateOfBirthMonth, DateOfBirthDay);
            BMR = GeneralFunction.CalculateBMR(Gender, Unit, Weight, Height, customer.DateOfBirth);
            BMR_IncludingActivity = GeneralFunction.CalculateBMR_IncludingActivityLevel(BMR, ActivityLevel);
            DailyCalorieIntake = GeneralFunction.CalculateDailyCalorieIntake(BMR_IncludingActivity, Goal);
            Calories = GeneralFunction.CalculateCalorieForGender(Gender, DailyCalorieIntake);
            MacroProtein = GeneralFunction.CalculateMacroProtein(Weight, Calories, Goal, Unit);
            MacroFat = GeneralFunction.CalculateMacroFat(Calories, Goal);
            MacroCarbohydrate = GeneralFunction.CalculateMacroCarbohydrate(Calories, MacroProtein, MacroFat);

            customer.Firstname = Firstname;
            customer.Lastname = Lastname;
            customer.Country = Country;
            customer.Gender = Gender;
            customer.Height = Height;
            customer.Weight = Weight;
            customer.ActivityLevel = ActivityLevel;
            customer.Unit = Unit;
            customer.Goal = Goal;
            customer.BMR = BMR;
            customer.BMR_IncludingActivity = BMR_IncludingActivity;
            customer.DailyCalorieIntake = DailyCalorieIntake;
            customer.Calories = Calories;
            customer.MacrosCarbohydrate = MacroCarbohydrate;
            customer.MacrosFat = MacroFat;
            customer.MacrosProtein = MacroProtein;
            customer.PhoneNumber = PhoneNumber;
            return customer;
        }

        //public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        //{
        //    var results = new List<ValidationResult>();

        //    if (DateTime.Compare(DateTime.Now, DateOfBirth) < 0)
        //        results.Add(new ValidationResult("Fecha invalida"));

        //    return results;
        //}
    }
}
