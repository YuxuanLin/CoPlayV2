﻿using System;
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

      
        public ActionResult FindClubs(ClubViewModels model)
        {
            var resultModel = new ClubViewModels();
            //Check model null
            if (model == null)
            {   //--> return error
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var foundClubs = _db.ClubModels.Where(pf => pf.SportType.Equals(model.SportType.ToString())
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
