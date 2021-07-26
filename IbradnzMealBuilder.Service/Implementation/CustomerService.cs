using IbradnzMealBuilder;
using IbradnzMealBuilder.Core;
using IbradnzMealBuilder.Data.Contract;
using IbradnzMealBuilder.Data.Implementation;
using IbradnzMealBuilder.Service.Contract;
using IbradnzMealBuilder.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IbradnzMealBuilder.Service.Implementation
{
    public class CustomerService : ICustomerService
    {
        private readonly UnitOfWork _uow;
        public CustomerService(IUnitOfWork uow)
        {
            this._uow = uow as UnitOfWork;
        }

        //public async Task AddNewCustomerFromRegister(ApplicationUser user)
        //{
        //    Customer customer = new Customer()
        //    {
        //        Fullname = "",
        //        DateOfBirth = DateTime.Now.AddDays(-1),
        //        SubscriptionExpiringDateUtc = DateTime.UtcNow,
        //        SubscriptionExpiringDate = DateTime.Now,
        //        City = "",
        //        Gender = Gender.Male,
        //        Weight = 1,
        //        Height = 1,
        //        Goal = Goal.FatLoss,
        //        ActivityLevel = ActivityLevel.Active,
        //        unit = Unit.Kgs,
        //        Calories = 1,
        //        BMR = 1,
        //        BMR_IncludingActivity = 1,
        //        MacrosCarbohydrate = 1,
        //        MacrosFat = 1,
        //        MacrosProtein = 1,
        //        UserId = user.Id,
        //        DailyCalorieIntake = 1,
        //    };
        //    if (_uow.CustomerRepo.GetAll().Where(u => u.UserId == user.Id).FirstOrDefault() != null)
        //        throw new Exception();

        //    _uow.CustomerRepo.Add(customer);
        //    await _uow.Save();
        //}

        public async Task AddCustomer(Customer customer,ApplicationUser user)
        {
            if (!ValidateCustomerDetails(customer))
                throw new Exception();

            if (_uow.CustomerRepo.GetAll().Where(u => u.UserId == user.Id).FirstOrDefault() != null)
                throw new Exception();

            _uow.CustomerRepo.Add(customer);
            user.IsAccountSetUpComplete = true;
            await _uow.Save();
        }

        public async Task EditCustomer(Customer customer, ApplicationUser user, bool editActivityLevelAndGoal=false)
        {
            if (!ValidateCustomerDetails(customer))
                throw new Exception();

            _uow.CustomerRepo.Update(customer);
            if(editActivityLevelAndGoal)
                user.IsAccountSetUpComplete = true;

            await _uow.Save();
        }

        public int GetAllCustomerCount()
        {
            return _uow.CustomerRepo.Count();
        }

        public Customer GetCustomerByUserId(string userId)
        {
            return _uow.CustomerRepo.FindInclude(u => u.UserId == userId).First();
        }

        public Customer GetCustomerById(int id, bool allowNull=false)
        {
            if (allowNull)
                return _uow.CustomerRepo.GetInclude(id);
            else
                return _uow.CustomerRepo.Get(id);

        }

        public IEnumerable<Customer> GetAllCustomers()
        {
            return _uow.CustomerRepo.GetAll();
        }

        private bool ValidateCustomerDetails(Customer customer)
        {
            if (customer == null)
                return false;

            if (string.IsNullOrEmpty(customer.UserId) || string.IsNullOrWhiteSpace(customer.UserId))
                return false;

            if (string.IsNullOrEmpty(customer.Firstname) || string.IsNullOrWhiteSpace(customer.Firstname) || !char.IsLetterOrDigit(customer.Firstname[0]))
                return false;

            if (customer.Height < 0.01D || customer.Weight< 0.01D)
                return false;
            if (DateTime.Compare(DateTime.Now, customer.DateOfBirth) < 0)
                return false;

            return true;
        }
    }
}
