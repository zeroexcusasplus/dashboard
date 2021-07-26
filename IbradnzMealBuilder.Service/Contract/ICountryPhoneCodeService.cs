using IbradnzMealBuilder.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace IbradnzMealBuilder.Service.Contract
{
    public interface ICountryPhoneCodeService
    {
        IEnumerable<CountryPhoneCode> GetAll();
        CountryPhoneCode Get(int id);
    }
}
