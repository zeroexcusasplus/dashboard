using IbradnzMealBuilder.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IbradnzMealBuilder.Models
{
    public class MacroNutrientViewModel
    {
        [Display(Name = "Gama de macro nutrientes")]
        public MacroNutrientRange MacroNutrientRange { get; set; }

        public MacroNutrientViewModel()
        {

        }
        public MacroNutrientViewModel(MacroNutrientRange macro)
        {
            MacroNutrientRange = macro;
        }
    }
}
