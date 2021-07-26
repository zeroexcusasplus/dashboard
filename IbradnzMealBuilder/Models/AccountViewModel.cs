using IbradnzMealBuilder.Core;
using IbradnzMealBuilder.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IbradnzMealBuilder.Models
{
    public class ChangePasswordViewModel
    {
        [Required(ErrorMessage = "Se requiere contraseña anterior")]
        [DataType(DataType.Password)]
        [Display(Name = "Contraseña actual")]
        public string OldPassword { get; set; }

        [Display(Name = "Nueva contraseña")]
        [Required(ErrorMessage = "Se requiere contraseña")]
        [StringLength(100, ErrorMessage = "La nueva contraseña debe tener {2} caracteres y no más de {1}.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirmar nueva contraseña")]
        [Compare("NewPassword", ErrorMessage = "La nueva contraseña y la contraseña de confirmación no coinciden")]
        public string ConfirmPassword { get; set; }
    }

    public class AccountDetailsViewModel
    {
        private Customer customer;
        private IEnumerable<SubscriptionModel> subscriptions;

        [Display(Name = "Correo Electronico")]
        public string Email { get; set; }
        [Display(Name = "Tipo de miembro")]
        public string Membership { get; set; }

        public Decimal Amount { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
        public DateTime DateExpire { get; set; }
        public int CustomerId { get; set; }

        [Required(ErrorMessage = "Se requiere contraseña anterior")]
        [DataType(DataType.Password)]
        [Display(Name = "Contraseña actual")]
        public string OldPassword { get; set; }

        [Display(Name = "Nueva contraseña")]
        [Required(ErrorMessage = "Se requiere contraseña")]
        [StringLength(100, ErrorMessage = "La nueva contraseña debe tener {2} caracteres y no más de {1}.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirmar nueva contraseña")]
        [Compare("NewPassword", ErrorMessage = "La nueva contraseña y la contraseña de confirmación no coinciden")]
        public string ConfirmPassword { get; set; }

        public bool PasswordResetConfirmed { get; set; }

        public AccountDetailsViewModel()
        {

        }

        public AccountDetailsViewModel(Customer customer, string email, bool passwordResetConfirmed=false)
        {
            
            Email = email;
           
                var customerSubscription = customer.Subscriptions.OrderByDescending(sub => sub.DateCreatedUtc);
                Membership = EnumExtensions.GetSubscriptionName(customerSubscription.FirstOrDefault().SubscriptionPlan);
                Amount = (decimal)customerSubscription.FirstOrDefault().Amount;
                DateCreated = customerSubscription.FirstOrDefault().DateCreated;
                DateModified = customerSubscription.FirstOrDefault().DateModified;
            DateExpire = customerSubscription.FirstOrDefault().Expirydate;
            
           
            CustomerId = customer.Id;
            passwordResetConfirmed = true;
        }

        public AccountDetailsViewModel(Customer customer, string email, IEnumerable<SubscriptionModel> subscriptions)
        {
            this.customer = customer;
            Email = email;
            this.subscriptions = subscriptions;
        }
    }
}
