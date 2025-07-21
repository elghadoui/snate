using Microsoft.AspNetCore.Mvc;
using snate.Data;
using snate.Models;
using snate.Models.DashHome;
using System;
using System.Diagnostics;

namespace snate.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _appDbContext;
        public HomeController(ILogger<HomeController> logger, ApplicationDbContext appDbContext)
        {
            _logger = logger;
            _appDbContext = appDbContext;
        }

        public IActionResult Index()
        {
            var viewModel = new DashHomeVM
            {

                TvnrecapList = _appDbContext.recapTvn.ToList() 
            };
            return View(viewModel);
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
