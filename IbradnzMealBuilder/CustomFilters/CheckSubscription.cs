using IbradnzMealBuilder.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IbradnzMealBuilder.CustomFilters
{
    public class CheckSubscriptionMeals : ActionFilterAttribute, IActionFilter
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var controllersUsingThisAttribute = ((MealsController)filterContext.Controller);
            var user = controllersUsingThisAttribute.GetLoggedInCustomer();
            if (DateTime.Compare(user.SubscriptionExpiringDateUtc,DateTime.UtcNow)<0)
                filterContext.Result = new RedirectResult("/Subscribe/Expired");

            base.OnActionExecuting(filterContext);
        }
    }

}
