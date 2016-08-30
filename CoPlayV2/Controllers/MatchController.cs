using CoPlayV2.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace CoPlayV2.Controllers
{
    public class MatchController : Controller
    {
        private CoPlayDBModel db = new CoPlayDBModel();

        private UserManager<ApplicationUser> userManager;

        public MatchController()
        {
            userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new ApplicationDbContext()));
        }

        // GET: Match
        [Authorize]
        public ActionResult Index()
        {
            return View("Step1");
        }

        [Authorize]
        public ActionResult Step1(MatchIndexViewModels model)
        {

            //Check model null
            if (model == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            //Search ids from usersportperformance table
            var foundIDs = db.UserSportPerformances
                .Where(pf => pf.Sport.Equals(model.Sports.SportsName)
                && pf.Level.Equals(model.Level.SportsLevel))
                ;

            //foreach ()



            if (!String.IsNullOrEmpty(model.Sports.SportsName.ToString()) && !String.IsNullOrEmpty(model.Level.SportsLevel.ToString()))
            {

                //            string searchSportString = model.Sports.SportsName.ToDisplayName().ToUpper();
                //            string searchLevelString = model.Level.SportsLevel.ToDisplayName().ToUpper();

                //            foundIDs = foundIDs.Where(s => s.Sport.ToUpper().Equals(searchSportString) && s.Level.ToUpper().Equals(searchLevelString));




                //            //var result = from users in db.AspNetUsers
                //            //           where users.userid in (
                //            //                   from userperformance in db.UserSportPerformances
                //            //                   where userperformance.level = model.level
                //            //                   && userperformance.sport = model.sport
                //            //                   select userperformance.UserID
                //            //                   )
                //            //            select user;
            }
            else
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            //Prepare result
            try
            {
                //            var preResult = new List<UserSportPerformance>();
                //            if (foundIDs.Count() == 0)//No one match
                //            {
                //                //ViewBag.prompt = "No result found" + model.lng + "," + model.lat;
                //                //return View("Index");
                //            }
                //            else //Find some ones's id matching
                //            {
                //                foreach (UserSportPerformance element in foundIDs)
                //                {
                //                    preResult.Add(element);
                //                }
                //            }
                //            var jsonSerialiser = new JavaScriptSerializer();
                //            var json = jsonSerialiser.Serialize(preResult);
                //            ViewBag.result = json;
                //            ViewBag.prompt = model.lng + "," + model.lat;
                return View("Index");
            }
            catch (System.ComponentModel.Win32Exception e)
            {
                ViewBag.prompt = "System.ComponentModel.Win32Exception error";
                return View("Index");
            }
            catch (System.Data.Entity.Core.EntityException e)
            {
                ViewBag.prompt = "System.Data.Entity.Core.EntityException error";
                return View("Index");
            }
        }


    }
}