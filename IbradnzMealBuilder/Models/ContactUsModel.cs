using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IbradnzMealBuilder.Models
{
    public class ContactUsModel
    {
        [Required(ErrorMessage = "Se requiere una aventura")]
        [Display(Name ="Asunto")]
        public string Affair { get; set; }

        [Required(ErrorMessage = "Se requiere mensaje")]
        [Display(Name = "Mensaje")]
        public string Message { get; set; }

        public bool MessageSent { get; set; }
    }
}
