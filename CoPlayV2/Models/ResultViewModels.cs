namespace CoPlayV2.Models
{

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public class ResultsViewModels
    {
        public ApplicationUser user { get; set; }
        public List<Event> MyEvent { get; set; }
    }


}