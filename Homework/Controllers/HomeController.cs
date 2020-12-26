using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Homework.Models;
using Homework.Domain;

namespace Homework.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public readonly IBlogService _blogService;

        public HomeController(ILogger<HomeController> logger, IBlogService blogService)
        {
            _logger = logger;
            _blogService = blogService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetBlogPosts(int page, string searchKeyWord = null)
        {
            BlogViewModel viewModel = new BlogViewModel();
            if (string.IsNullOrEmpty(searchKeyWord))
                viewModel.ArticlesList = _blogService.GetArticles(page, viewModel.VisiblePage);
            else
                viewModel.ArticlesList = _blogService.GetArticles(searchKeyWord, page, viewModel.VisiblePage);

            return PartialView("_BlogPostPartialView", viewModel);
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
