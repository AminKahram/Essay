using Microsoft.AspNetCore.Mvc;
using Security.Application.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Essay.Components.RoleComponents
{
    [ViewComponent(Name = "RoleDrp")]
    public class RoleDrpViewComponent: ViewComponent
    {
        private readonly IRoleApplication roleApplication;
        public RoleDrpViewComponent(IRoleApplication roleApplication)
        {
            this.roleApplication = roleApplication;
        }
        public IViewComponentResult Invoke()
        {
            var roles = roleApplication.GetRoles();
            return View(roles);
        }
    }
}
