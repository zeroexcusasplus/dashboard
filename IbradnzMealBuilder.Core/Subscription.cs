using IbradnzMealBuilder.Utility;
using System;
using System.Collections.Generic;
using System.Text;

namespace IbradnzMealBuilder.Core
{
    public class Subscription:Entity
    {
        public string UserId { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string ZipCode { get; set; }
        public Customer Customer { get; set; }
        public decimal Amount { get; set; }
        public DateTime Expirydate { get; set; }
        public SubscriptionPlan SubscriptionPlan { get; set; }
    }
}
