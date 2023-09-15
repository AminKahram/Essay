using Framework.DomainModel.BaseDomainModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Essay.Components
{
    [ViewComponent(Name = "ClientArticlePager")]
    public class ClientArticlePagerViewComponent: ViewComponent
    {
        public IViewComponentResult Invoke(int pagecount)
        {
            PageModel pager = new PageModel { PageCount = pagecount };
            return View(pager);
        }
    }
}
