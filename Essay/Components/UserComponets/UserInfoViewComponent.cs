using Microsoft.AspNetCore.Mvc;
using Security.Application.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Essay.Components.UserComponets
{
    [ViewComponent(Name ="UserInfo")]
    public class UserInfoViewComponent : ViewComponent
    {
        private readonly IAccountApplication accountApplication;
        public UserInfoViewComponent(IAccountApplication accountApplication)
        {
            this.accountApplication = accountApplication;
        }

        public IViewComponentResult Invoke(int ID)
        {
            var user = accountApplication.Get(ID);
            return View(user);
        }
    }
}
