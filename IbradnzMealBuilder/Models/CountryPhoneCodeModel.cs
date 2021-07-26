using IbradnzMealBuilder.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IbradnzMealBuilder.Models
{
    public class ViewCountryPhoneCodeModel
    {
        public int Id { get; set; }
        public bool Selected { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public ViewCountryPhoneCodeModel(CountryPhoneCode countryPhoneCode, bool selected=false)
        {
            Id = countryPhoneCode.Id;
            Selected = selected;
            Name = countryPhoneCode.Name;
            Code = countryPhoneCode.Code;
        }
    }
}
