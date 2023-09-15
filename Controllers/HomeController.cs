using Article.DomainModel.Query.Article;
using Essay.Helper;
using Essay.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Essay.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ClientSearch(ArticleSearchModel sm)
        {
            return ViewComponent("ArticleClientList", sm);
        }
        public IActionResult ClientMenuSearch(int ID, ArticleSearchModel sm)
        {
            if (ID != 0)
            {
                sm = new ArticleSearchModel { CategoryID = ID,ArticleSubject=sm.ArticleSubject };
            }
            //return ViewComponent("ArticleClientListSearch", sm);
            return View(sm);
        }
        public IActionResult ClientItem(int ID)
        {
            return ViewComponent("ArticleClientItem", ID);
        }
        [ServiceFilter(typeof(CustomeAuthenticator))]
        public IActionResult AdminIndex()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
