using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SLABuilder.Models;
using MongoDB.Driver;
using MongoDB.Bson;
using Microsoft.Extensions.Configuration;
using System.Net.Http;

namespace SLABuilder.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IMongoClient _mongoClient;
        private readonly IConfiguration _configuration;
        //private readonly IHttpClientFactory _httpClientFactory;

        public HomeController(ILogger<HomeController> logger, IMongoClient mongoClient, IConfiguration configuration)
        {
            _logger = logger;
            _mongoClient = new MongoClient(configuration["Mongo:ConnectionString"]);
            _configuration = configuration;
            //_httpClientFactory = httpClientFactory;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Dashboard()
        {
            return View();
        }

        public IActionResult Administration()
        {
            return View("Views/Administration/Administration.cshtml");
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
