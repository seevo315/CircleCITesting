using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MongoDB.Bson;
using MongoDB.Driver;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;
using SLABuilderModels;
using Newtonsoft.Json;

namespace SLABuilderAPI.Controllers
{
    public class SLAController : Controller
    {
        private readonly IMongoClient _mongoClient;
        private readonly IConfiguration _configuration;
        private readonly ILogger<SLAController> _logger;

        public SLAController(ILogger<SLAController> logger, IMongoClient mongoClient, IConfiguration configuration)
        {
            _configuration = configuration;
            _logger = logger;
            _mongoClient = new MongoClient(_configuration["Mongo:ConnectionString"]);

        }

        #region Gets
        // GET: SLA
        public ActionResult Index()
        {
            return View();
        }

        // GET: SLA/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SLA/Create
        public ActionResult Create()
        {
            return View();
        }

        // GET: SLA/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }
        // GET: SLA/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        #endregion

        #region Actions
        // POST: SLA/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("create")]
        public ActionResult Create(SLADocument SlaDoc)
        {
            try
            {
                var database = _mongoClient.GetDatabase(_configuration["Mongo:Database"]);
                var col = database.GetCollection<BsonDocument>("SLA");
                BsonDocument doc = JsonConvert.SerializeObject(SlaDoc).ToBsonDocument();
                col.InsertOne(doc, null);
                return Ok();

            }
            catch
            {
                return View();
            }
        }



        // POST: SLA/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }


        // POST: SLA/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        #endregion

    }
}