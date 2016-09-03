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
        //DBcontext to tables except usertables
        private readonly CoPlayDBModel _db = new CoPlayDBModel();

        //Create defualt userManager to connect to user table
        private ApplicationUserManager _userManager;

        private ApplicationUserManager UserManager
        {
            get
            {
                return _userManager ?? Request.GetOwinContext().GetUserManager<ApplicationUserManager>();
            }
            set
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
        public async Task<ActionResult> FindOpponents(MatchIndexViewModels model)
        {

            //Check model null
            if (model == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            //Search ids from usersportperformance table
            var foundIDs = _db.UserSportPerformances
                .Where(pf => pf.Sport.Equals(model.Sports.SportsName.ToString())
                && pf.Level.Equals(model.Level.SportsLevel.ToString()))
                ;

            //Prepare to get users from user table
            var users = new List<MyUser>();
            
            //Get user from usertable and put it into "users" collection
            foreach (var x in foundIDs)
            {
                var user = await UserManager.FindByIdAsync(x.UserID);
                if (user == null) continue;
                //Add user
                var myUser = new MyUser {user = user};
                var events = _db.Events.Where(e => e.Sport.Equals(
                    model.Sports.SportsName.ToString()));
                users.Add(myUser);
                //Get events from users
            }

            
            ViewBag.users = users;
            return View("Result");
        }

        [Authorize]
        public ActionResult Result()
        {
            return View("Result");
        }

    }
}