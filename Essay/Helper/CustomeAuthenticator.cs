using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Routing;
using Security.Application.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Essay.Helper
{
    public class CustomeAuthenticator : ActionFilterAttribute
    {
        private readonly IAuthHelper authHelper;
        private readonly IAccountApplication accountApplication;
        public CustomeAuthenticator(IAuthHelper authHelper, IAccountApplication accountApplication)
        {
            this.authHelper = authHelper;
            this.accountApplication = accountApplication;
        }
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if (!context.HttpContext.User.Identity.IsAuthenticated)
            {
                context.Result = new RedirectToRouteResult(new RouteValueDictionary(new { controller = "Account", action = "Login" }));
                //context.HttpContext.Response.Redirect("/Account/Login");
                return ;
            }
            var u = authHelper.GetCurrentUserInfo();
            if (u == null)
            {
                //context.HttpContext.Response.Redirect("/Account/Login");
                context.Result = new RedirectToRouteResult(new RouteValueDictionary(new { controller = "Account", action = "Login" }));

                return;
            }
            var ControllerName = context.RouteData.Values["Controller"].ToString();
            var ActionName = context.RouteData.Values["Action"].ToString();
            var username = context.HttpContext.User.Identity.Name;
            Security.Domain.Model.Query.CheckPermission permission = new Security.Domain.Model.Query.CheckPermission
            {
                ActionName = ActionName,
                ControllerName = ControllerName,
                UserName = username
            };
            var p = accountApplication.CheckForPermission(permission);
            if (!p)
            {
                //context.HttpContext.Response.Redirect("/Account/Login");
                context.Result = new RedirectToRouteResult(new RouteValueDictionary(new { controller = "Account", action = "Login" }));

                return;
            }
            base.OnActionExecuting(context);
        }
    }
}
