using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Practice_Project.Models;
using Practice_Project.Interfaces;

namespace Practice_Project.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IModelTransformation _modelTransform;

        public HomeController(ILogger<HomeController> logger, IModelTransformation modelTransform)
        {
            _logger = logger;
            _modelTransform = modelTransform;
        }

        [HttpGet]
        public IActionResult Index()
        {
            IndexViewModel viewModel = new IndexViewModel();
            return View(viewModel);
        }

        [HttpGet]
        public IActionResult Index2()
        {
            IndexViewModel viewModel = new IndexViewModel();
            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Success(IndexViewModel viewModel)
        {
            string firstName = viewModel.FirstName;
            string lastName = viewModel.LastName;
            int age = viewModel.Age;

            _modelTransform.Transform(viewModel);

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
