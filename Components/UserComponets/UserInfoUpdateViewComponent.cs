using Microsoft.AspNetCore.Mvc;
using Security.Application.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Essay.Components.UserComponets
{
    [ViewComponent(Name = "UserInfoUpdate")]
    public class UserInfoUpdateViewComponent: ViewComponent
    {
        private readonly IAccountApplication accountApplication;
        public UserInfoUpdateViewComponent(IAccountApplication accountApplication)
        {
            this.accountApplication = accountApplication;
        }
        public IViewComponentResult Invoke(int id)
        {
            var user = accountApplication.Get(id);
            return View(user);
        }
    }
}
