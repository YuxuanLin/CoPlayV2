using CoPlayV2.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace CoPlayV2.Controllers
{
    public class SportSpotsController : Controller
    {
        private CoPlayV2_dbEntities db = new CoPlayV2_dbEntities();
        // GET: SportandRecs/Details/5
        public ActionResult Search(SportSearchViewModels model)
        {
            if (model == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var results = from s in db.SportandRecs select s;
            //Prepare searching string
            // this.Request.QueryString[""];
            // Request[]
            //HttpUtility.ParseQueryString(querystring);
            if (!String.IsNullOrEmpty(model.Sports.SportsName.ToString()) && !String.IsNullOrEmpty(model.Suburbs.SuburbName.ToString()))
            {
                if (model.Suburbs.SuburbName.ToString().Equals("CURRENT"))
                {

                }
                else
                {
                    string searchSportString = model.Sports.SportsName.ToDisplayName().ToUpper();
                    string searchSuburbString = model.Suburbs.SuburbName.ToDisplayName().ToUpper();

                    results = results.Where(s => s.SportsPlayed.ToUpper().Equals(searchSportString) && s.SuburbTown.ToUpper().Equals(searchSuburbString));
                }
            }
            //Prepare result
            var preResult = new List<SportandRec>();
            if (results.Count() == 0)
            {
                ViewBag.prompt = "No result found";
                return View("Index");
            }
            else
            {
                foreach (SportandRec element in results)
                {
                    preResult.Add(element);
                }
            }
            var jsonSerialiser = new JavaScriptSerializer();
            var json = jsonSerialiser.Serialize(preResult);
            ViewBag.result = json;
            return View("Index");
        }


        // GET: SportSpots
        public ActionResult Index()
        {
            return View();
        }
    }
}