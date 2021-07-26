using IbradnzMealBuilder.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IbradnzMealBuilder.Models
{
    public class SubscriptionModel
    {
        public int Id { get; set; }
        public DateTime DateCreated { get; set; }
        public string DateTimeCreatedString { get; set; }
        public string SubscriptionPlan { get; set; }
        public string Amount { get; set; }
    }

    public class ViewSubscriptionsViewModel
    {
        public IEnumerable<SubscriptionModel> Subscriptions { get; set; }
        public string SubscriptionExpiringDate { get; set; }
        public ViewSubscriptionsViewModel(IEnumerable<SubscriptionModel> subscriptions,DateTime subscriptionExpiringDate)
        {
            Subscriptions = subscriptions;
            SubscriptionExpiringDate = subscriptionExpiringDate.ToString("dd/MMM/yyyy hh:mm tt") + " GMT";
        }
    }
}
