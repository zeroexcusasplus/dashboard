using IbradnzMealBuilder.Core;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace IbradnzMealBuilder.Service.Contract
{
    public interface ICustomerService
    {
        int GetAllCustomerCount();
        //Task AddNewCustomerFromRegister(ApplicationUser user);
        Task AddCustomer(Customer customer,ApplicationUser user);
        Customer GetCustomerByUserId(string userId);
        Customer GetCustomerById(int id, bool allowNull = false);
        Task EditCustomer(Customer customer, ApplicationUser user, bool editActivityLevelAndGoal = false);
        IEnumerable<Customer> GetAllCustomers();
    }
}
