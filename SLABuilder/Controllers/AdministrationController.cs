using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SLABuilderModels;
using MongoDB.Driver;
using MongoDB.Bson;
using Microsoft.Extensions.Configuration;
using System.Net.Http;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace SLABuilder.Controllers
{
    public class AdministrationController : Controller
    {
        private readonly ILogger<AdministrationController> _logger;
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IMongoClient _mongoClient;
        private readonly IConfiguration _configuration;

        public AdministrationController(ILogger<AdministrationController> logger, IMongoClient mongoClient, IConfiguration configuration)
        {
            _logger = logger;
            _mongoClient = mongoClient;
            _configuration = configuration;
        }

        public IActionResult Index()
        {
            return View("Adminstration");
        } 


        public ActionResult CreateSlaDocument(SLADocument document)
        {

            return View("CreateSLA");


            //_logger.LogInformation("Begin SLAController.Create");

            //using (HttpClient client =new HttpClient())
            //{
            //    var stringContent = new StringContent(JsonConvert.SerializeObject(document));
            //    using (var response =  client.PostAsync(_configuration["API:CreateUrl"], stringContent)) 
            //    {
            //        if(response.Status == TaskStatus.RanToCompletion)
            //        {
            //            _logger.LogInformation("SLAController.Create complete.");
            //            return Ok();
            //        }
            //    }
            //}

            //_logger.LogError("SLAController.Create failure.");
            //return BadRequest();
        }
    }
}