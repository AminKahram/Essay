using Microsoft.AspNetCore.Mvc;
using Security.Application.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Essay.Components.UserComponets
{
    [ViewComponent(Name = "UserInfoPasswordUpdate")]
    public class UserInfoPasswordUpdateViewComponent: ViewComponent
    {
        private readonly IAccountApplication accountApplication;
        public UserInfoPasswordUpdateViewComponent(IAccountApplication accountApplication)
        {
            this.accountApplication = accountApplication;
        }
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
