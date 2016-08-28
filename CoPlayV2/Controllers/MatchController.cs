using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CoPlayV2.Controllers
{
    public class MatchController : Controller
    {
        // GET: Match
        [Authorize]
        public ActionResult Index()
        {
            return View();
        }
    }
}