using CoPlayV2.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace CoPlayV2.Controllers
{
    public class MatchController : Controller
    {
        private CoPlayDBModel db = new CoPlayDBModel();

        private ApplicationUserManager _userManager;

        public ApplicationUserManager UserManager
        {
            get
            {
                return _userManager ?? Request.GetOwinContext().GetUserManager<ApplicationUserManager>();
            }
            private set
            {
                _userManager = value;
            }
        }

        // GET: Match
        [Authorize]
        public ActionResult Index()
        {
            return View("Index");
        }

        [Authorize]
        public async Task<ActionResult> Step2(MatchIndexViewModels model)
        {

            //Check model null
            if (model == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            //Search ids from usersportperformance table
            var foundIDs = db.UserSportPerformances
                .Where(pf => pf.Sport.Equals(model.Sports.SportsName.ToString())
                && pf.Level.Equals(model.Level.SportsLevel.ToString()))
                ;
            List<ApplicationUser> users = new List<ApplicationUser>();
            foreach (var x in foundIDs)
            {
                var user = await UserManager.FindByIdAsync(x.UserID);
                if (user != null)
                {
                    users.Add(user);
                }
               
            }
            ViewBag.users = users;
            return View("Step2");

            
        }


    }
}