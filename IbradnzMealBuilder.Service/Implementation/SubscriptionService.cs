using IbradnzMealBuilder.Core;
using IbradnzMealBuilder.Data.Contract;
using IbradnzMealBuilder.Data.Implementation;
using IbradnzMealBuilder.Service.Contract;
using System;
using System.Collections.Generic;
using System.Text;
using IbradnzMealBuilder.Utility;
using System.Threading.Tasks;
using System.Linq;

namespace IbradnzMealBuilder.Service.Implementation
{
    public class SubscriptionService : ISubscriptionService
    {
        private readonly UnitOfWork _uow;
        public SubscriptionService(IUnitOfWork uow)
        {
            this._uow = uow as UnitOfWork;
        }


        public int GetAllSubscriptionCount()
        {
            return _uow.SubscriptionRepo.Count();
        }

        public async Task AddSubscription(Subscription subscription, Customer customer)
        {
            if (!ValidateSubscriptionDetails(subscription))
                throw new Exception();
            if(subscription.SubscriptionPlan==SubscriptionPlan.Monthly)
            {
                customer.SubscriptionExpiringDate = DateTime.Now.AddMonths(1);
                customer.SubscriptionExpiringDateUtc = DateTime.UtcNow.AddMonths(1);
            }
            else if(subscription.SubscriptionPlan == SubscriptionPlan.Yearly)
            {
                customer.SubscriptionExpiringDate = DateTime.Now.AddYears(1);
                customer.SubscriptionExpiringDateUtc = DateTime.UtcNow.AddYears(1);
            }

            _uow.SubscriptionRepo.Add(subscription);
            _uow.CustomerRepo.Update(customer);
            await _uow.Save();
        }

        public IEnumerable<Subscription> GetAllCustomerSubscriptions(Customer customer)
        {
            return _uow.SubscriptionRepo.GetAll().Where(s => s.Customer == customer);
        }

        private bool ValidateSubscriptionDetails(Subscription subscription)
        {
            if (subscription == null)
                return false;
            if (subscription.Customer == null)
                return false;
            //if (subscription.Amount < 0 && subscription.SubscriptionPlan != SubscriptionPlan.Free)
            //    return false;

            return true;
        }
    }
}
