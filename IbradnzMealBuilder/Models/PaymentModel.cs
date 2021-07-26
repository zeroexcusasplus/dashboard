using IbradnzMealBuilder.Core;
using IbradnzMealBuilder.Utility;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IbradnzMealBuilder.Models
{
    public class PaymentModel
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string ZipCode { get; set; }

        [Display(Name = "Número de tarjeta")]
        public string CardNumber { get; set; }

        [Range(1,12)]
        [Display(Name = "Mes")]
        public int Month { get; set; }

        [Display(Name = "Año")]
        public int Year { get; set; }

        public string Cvc { get; set; }

        public decimal Amount { get; set; }

       
        public string CouponCode { get; set; }

        [Display(Name = "Plan de suscripción")]
        public SubscriptionPlan SubscriptionPlan { get; set; }
        public PaymentModel(SubscriptionPlan plan)
        {
            SubscriptionPlan = plan;
        }
        public PaymentModel()
        {

        }
    }

    public class SubscriptionPlanModel
    {
        public SubscriptionPlan Plan { get; set; }
        public string CustomerCalories { get; set; }
        public string PlanName { get; set; }
        public string PriceDescription { get; set; }
        public SubscriptionPlanModel(Customer customer)
        {
            CustomerCalories = customer.Calories.ToString();

            Plan = SubscriptionPlan.Monthly;
            PlanName = EnumExtensions.GetSubscriptionName(SubscriptionPlan.Monthly);
            PriceDescription = EnumExtensions.GetSubscriptionPriceDesc(SubscriptionPlan.Monthly);
        }

        public SubscriptionPlanModel(SubscriptionPlan plan)
        {
            Plan = plan;
            PlanName = EnumExtensions.GetSubscriptionName(plan);
            PriceDescription = EnumExtensions.GetSubscriptionPriceDesc(plan);
        }
        public SubscriptionPlanModel()
        {

        }
    }
}
