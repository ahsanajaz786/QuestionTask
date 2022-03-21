using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using QuestionTask.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json;
using Newtonsoft.Json;
using QuestionTask.Domain.DTO;

namespace QuestionTask.Controllers
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
        public async Task<IActionResult> RenderJsonQuestions()

        {
          
            return View();
        }
        public IActionResult RenderJson(string json)
        {
            var question = new List<JsonQuestion>();

            try
            {
                question = JsonConvert.DeserializeObject<List<JsonQuestion>>(json);
            }
            catch (Exception l)
            {
                ViewBag.error = "Invalid json";

            }
            return View(question);
        }
        public async Task<IActionResult> Users()
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
