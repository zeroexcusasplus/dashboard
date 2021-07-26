using IbradnzMealBuilder.Utility;
using System;
using System.Collections.Generic;
using System.Text;

namespace IbradnzMealBuilder.Core
{
    public class Customer:Entity
    {
        public string UserId { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Country { get; set; }
        public string PhoneNumber { get; set; }
        public Gender Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Unit Unit { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }
        public ActivityLevel ActivityLevel { get; set; }
        public Goal Goal { get; set; }
        public double BMR { get; set; }
        public double BMR_IncludingActivity { get; set; }
        public double DailyCalorieIntake { get; set; }
        public double Calories { get; set; }
        public double MacrosCarbohydrate { get; set; }
        public double MacrosProtein { get; set; }
        public double MacrosFat { get; set; }
        public DateTime SubscriptionExpiringDate { get; set; }
        public DateTime SubscriptionExpiringDateUtc { get; set; }

        public IEnumerable<ProfileImage> ProfileImages { get; set; }
        public IEnumerable<Subscription> Subscriptions { get; set; }
        public IEnumerable<MealBuilder> MealBuilders { get; set; }

    }
}
