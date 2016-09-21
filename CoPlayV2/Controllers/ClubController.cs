using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using CoPlayV2.Models;
using Microsoft.AspNet.Identity;

namespace CoPlayV2.Controllers
{
    public class ClubController : Controller
    {
        // GET: Club
        public ActionResult Index()
        {
            return View();
        }

        private CoPlayDBModel _db = new CoPlayDBModel();

        [Authorize]
        public ActionResult FindClubs(ClubViewModels model)
        {
            var resultModel = new ClubViewModels();
            //Check model null
            if (model == null)
            {   //--> return error
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }


            string sportType = null;
            switch (model.SportType)
            {
                case "Badminton":
                    sportType = "Badminton";
                    break;
                case "FitnessGymnasiumWorkouts":
                    sportType = "Fitness/gymnasium";
                    break;
                case "SquashRacquetball":
                    sportType = "Racquetball/Squash";
                    break;
                case "Swimming":
                    sportType = "Swimming";
                    break;
                case "TableTennis":
                    sportType = "Table Tennis";
                    break;
                case "TennisIndoor":
                    sportType = "Tennis(Indoor)";
                    break;
                case "TennisOutdoor":
                    sportType = "Tennis(outdoor)";
                    break;
            }

            var foundClubs = _db.ClubModels.Where(pf => pf.SportType.Equals(sportType)
                && pf.Type.Equals(model.Type.ToString()))
                ;

            resultModel.ClubsList = new List<ClubModel>();
            //Get user from usertable and put it into "users" collection
            foreach (var club in foundClubs)
            {

                resultModel.ClubsList.Add(club);
            }


            return View("Result",resultModel);
        }

    }
}