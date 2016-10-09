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
        private CoPlayDBModel db = new CoPlayDBModel();
        
        // GET: SportSpots/Search
        
        public ActionResult Search(SportSearchViewModels model)
        {
            if (model == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var results = from s in db.SportandRecs select s;
            //Prepare searching string
            if (!String.IsNullOrEmpty(model.Sports.SportsName.ToString()) && !String.IsNullOrEmpty(model.Campus.ToString()))
            {
                string[] suburbs = {};
                switch (model.Campus.ToString())
                {
                    case "CityOfMonash_clayton_":
                        suburbs = new string[] { "Ashwood", "Chadstone", "Clayton", "GlenWaverley", "MonashUniversity", "MountWaverley", "Mulgrave", "NottingHill", "Oakleigh", "OakleighEast", "OakleighSouth" };
                        break;
                    case "CityOfGlenEira_Caulfield_":
                        suburbs = new string[] { "Bentleigh", "BentleighEast", "Caulfield", "CaulfieldEast", "CaulfieldNorth", "CaulfieldSouth", "Carnegie", "Elsternwick", "GlenHuntly", "McKinnon", "Murrumbeena", "Ormond" };
                        break;
                    case "CityOfMelbourne_Parkville_":
                        suburbs = new string[] { "Berwick", "Clyde", "ClydeNorth", "Cranbourne", "CranbourneEast", "CranbourneNorth", "CranbourneSouth", "Doveton", "EndeavourHills", "Eumemmerring", "Hallam", "HamptonPark", "Harkaway", "JunctionVillage", "Lynbrook", "NarreWarren", "NarreWarrenNorth", "NarreWarrenSouth", "Pearcedale", "Tooradin", "Warneet" };
                        break;
                    case "ShireOfMorningtonPeninsula_Peninsula_":
                        suburbs = new string[] { "Carlton", "Jolimont", "Flemington", "Kensington", "Melbourne", "NorthMelbourne", "PortMelbourne", "Parkville", "Southbank", "SouthYarra", "WestMelbourne" };
                        break;
                    case "CityOfCasey_Berwick_":
                        suburbs = new string[] { "Balnarring", "BalnarringBeach", "Bittern", "Blairgowrie", "Boneo", "CapeSchanck", "CribPoint", "Dromana", "Flinders", "Hastings", "HMASCerberus", "MainRidge", "Merricks", "MerricksBeach", "Moorooduc", "Mornington", "MountEliza", "MountMartha", "PointLeo", "Portsea", "RedHill", "Rosebud", "RosebudWest", "Rye", "SafetyBeach", "Shoreham", "Somers", "Somerville", "Sorrento", "Tootgarook", "Tyabb" };
                        break;
                }
                 
                string searchSportString = model.Sports.SportsName.ToDisplayName().ToUpper();
                    string searchCampusString = model.Campus.ToDisplayName().ToUpper();
                    
                    results = results.Where(s => s.SportsPlayed.ToUpper().Equals(searchSportString) && suburbs.Contains(s.SuburbTown));
            }
            //Prepare result

            try
            {
                var preResult = new List<SportandRec>();
                if (!results.Any())
                {
                    //ViewBag.prompt = "No result found" + model.lng + "," + model.lat;
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
                //ViewBag.prompt = model.lng + "," + model.lat;
                return View("Index");
            }
            catch(System.ComponentModel.Win32Exception e)
            {
                ViewBag.prompt = "System.ComponentModel.Win32Exception error";
                return View("Index");
            }
            catch(System.Data.Entity.Core.EntityException  e)
            {
                ViewBag.prompt = "System.Data.Entity.Core.EntityException error";
                return View("Index");
            }
        }


        // GET: SportSpots
        
        public ActionResult Index()
        {
            return View("Index");
        }
    }
}