using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CoPlayV2.Models
{
    public class SportSearchViewModels
    {
        public Suburb Suburbs { get; set; }
        public SportTypeModel Sports { get; set; }
        public string lng { get; set; }
        public string lat { get; set; }
    }
}