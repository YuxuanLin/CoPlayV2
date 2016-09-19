using CoPlayV2.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using System;
using System.Collections.Generic;
using System.Data;
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
            var resultModel = new ResultsViewModels();
            //Check model null
            if (model == null)
            {   //--> return error
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var level = "";
            //Search ids from usersportperformance table

            //Enum problem
            switch (model.Level.SportsLevel.ToString())
            {
                case "low":
                    level = "low";
                    break;
                case "mid":
                    level = "mid";
                    break;
                case "high":
                    level = "high";
                    break;
            }
            var foundIDs = _db.UserSportPerformances
                .Where(pf => pf.Sport.Equals(model.Sports.SportsName.ToString())
                && pf.Level.Equals(level))
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
                //var events = _db.Events.Where(e => e.Sport.Equals(
                //    model.Sports.SportsName.ToString()));
                users.Add(myUser);
                //Get events from users
            }
            resultModel.users = users;
            resultModel.Level = model.Level;
            resultModel.Sports = model.Sports;
         
            return View("Result",resultModel);
        }

        [Authorize]
        public ActionResult Result()
        {
            return View("Result");
        }

        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateMessage(SendMessage myMessage)
        {

            var internalMssage = new InternalMessage
            {
                Message = myMessage.message,
                ReceiverID = myMessage.receiver.user.Id,
                SenderID = User.Identity.GetUserId(),
                Status = 0
            };

            _db.InternalMessages.Add(internalMssage);
            _db.SaveChanges();
            return RedirectToAction("Index");
           
        }

        [Authorize]
        public async Task<ActionResult> SendMessage( string id )
        {

            var result = new SendMessage();
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
           
            var receiverUser = await UserManager.FindByIdAsync(id);
            if (receiverUser != null)
            {
                result.receiver = new MyUser { user = receiverUser };
            }
            else
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            
            return View("MessageIndex",result);
        }
        

    }
}