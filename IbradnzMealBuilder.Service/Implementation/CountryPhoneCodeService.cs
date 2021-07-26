using IbradnzMealBuilder.Core;
using IbradnzMealBuilder.Data.Contract;
using IbradnzMealBuilder.Data.Implementation;
using IbradnzMealBuilder.Service.Contract;
using System;
using System.Collections.Generic;
using System.Text;

namespace IbradnzMealBuilder.Service.Implementation
{
    public class CountryPhoneCodeService : ICountryPhoneCodeService
    {
        private readonly UnitOfWork _uow;
        public CountryPhoneCodeService(IUnitOfWork uow)
        {
            _uow = uow as UnitOfWork;
        }

        public CountryPhoneCode Get(int id)
        {
            return _uow.CountryPhoneCodeRepo.Get(id);
        }

        public IEnumerable<CountryPhoneCode> GetAll()
        {
            return _uow.CountryPhoneCodeRepo.GetAll();
        }
    }
}
