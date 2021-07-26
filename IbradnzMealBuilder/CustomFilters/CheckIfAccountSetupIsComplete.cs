using IbradnzMealBuilder.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IbradnzMealBuilder.CustomFilters
{
    public class CheckIfAccountSetupIsComplete : ActionFilterAttribute, IActionFilter
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var controllersUsingThisAttribute = ((AccountController)filterContext.Controller);
            var user = controllersUsingThisAttribute.GetLoggedInUser();
            if (user!=null)
            {
                if (!user.IsAccountSetUpComplete)
                    filterContext.Result = new RedirectResult("/Account/SetupProfile");
            }
            base.OnActionExecuting(filterContext);
        }
    }

    public class CheckIfAccountSetupIsCompleteMealController : ActionFilterAttribute, IActionFilter
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var controllersUsingThisAttribute = ((MealsController)filterContext.Controller);
            var user = controllersUsingThisAttribute.GetLoggedInUser();
            if (user != null)
            {
                if (!user.IsAccountSetUpComplete)
                    filterContext.Result = new RedirectResult("/Account/SetupProfile");
            }
            base.OnActionExecuting(filterContext);
        }
    }

    public class CheckIfAccountIsCompleteSubscribeController: ActionFilterAttribute, IActionFilter
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var controllersUsingThisAttribute = ((SubscribeController)filterContext.Controller);
            var user = controllersUsingThisAttribute.GetLoggedInUser();
            if (user != null)
            {
                if (!user.IsAccountSetUpComplete)
                    filterContext.Result = new RedirectResult("/Account/SetupProfile");
            }
            base.OnActionExecuting(filterContext);
        }
    }

    public class CheckIfAccountIsComplete_TrainingController : ActionFilterAttribute, IActionFilter
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var controllersUsingThisAttribute = ((TrainingController)filterContext.Controller);
            var user = controllersUsingThisAttribute.GetLoggedInUser();
            if (user != null)
            {
                if (!user.IsAccountSetUpComplete)
                    filterContext.Result = new RedirectResult("/Account/SetupProfile");
            }
            base.OnActionExecuting(filterContext);
        }
    }

}
