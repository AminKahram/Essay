using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Essay.Components.KeywordComponents
{
    [ViewComponent(Name = "KeywordAdd")]
    public class KeywordAddViewComponent: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
