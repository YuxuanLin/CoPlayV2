using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CoPlayV2.Models
{
    public class ClubViewModels
    {
        
        public string SportType { get; set; }

        public string Type { get; set; }


        public List<ClubModel> ClubsList { get; set; }

    }
}