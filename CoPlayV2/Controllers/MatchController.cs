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
            switch (model.Level.SportsLevel.ToString())
            {
                case "Low":
                    level = "low";
                    break;
                case "Middle":
                    level = "mid";
                    break;
                case "High":
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
        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult CreateMessage([Bind(Include = "receiver,message")]CreateMessage message)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var myMessage = new InternalMessage();
                    myMessage.Message = message.message;
                    myMessage.ReceiverID = message.receiver.user.Id;
                    myMessage.SenderID = User.Identity.GetUserId();
                    _db.InternalMessages.Add(myMessage);
                    _db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            catch (DataException /* dex */)
            {
                //Log the error (uncomment dex variable name and add a line here to write a log.
                ModelState.AddModelError("", "Unable to save changes. Try again, and if the problem persists see your system administrator.");
            }


            //get the sender

            return View("MessageIndex");
        }

        [Authorize]
        public async Task<ActionResult> SendMessage( string id)
        {

            var result = new CreateMessage();
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
           
            var receiverUser = await UserManager.FindByIdAsync(id);
            if (receiverUser != null)
            {
                var receiver = new MyUser {user = receiverUser };
                result.receiver = receiver;
            }
            else
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            

            return View("MessageIndex",result);
        }
        

    }
}