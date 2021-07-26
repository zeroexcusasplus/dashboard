using IbradnzMealBuilder.Core;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace IbradnzMealBuilder.Service.Contract
{
    public interface ISubscriptionService
    {
        int GetAllSubscriptionCount();
        Task AddSubscription(Subscription subscription, Customer customer);
        IEnumerable<Subscription> GetAllCustomerSubscriptions(Customer customer);
    }
}
