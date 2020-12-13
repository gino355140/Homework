using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Homework.Models;
using Homework.Database;
using Homework.Domain.AutoMapper;

namespace Homework.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public readonly BlogDbContext _blogContext;

        public HomeController(ILogger<HomeController> logger,BlogDbContext blogContext)
        {
            _logger = logger;
            _blogContext = blogContext;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult BlogPostPartialView()
        {
            BlogViewModel viewModel = new BlogViewModel();

            var daoArticles = _blogContext.Articles.ToList();

            var config = new AutoMapper.MapperConfiguration(cfg => cfg.AddProfile<ServiceMappings>());
            var mapper = config.CreateMapper(); // 用設定檔建立 Mapper
            var result = mapper.Map<IEnumerable<Domain.Articles>>(daoArticles); // 轉換型別

            viewModel.ArticlesList.AddRange(result.ToList());

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
