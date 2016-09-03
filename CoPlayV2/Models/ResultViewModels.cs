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
        public List<MyUser> users { get; set; }
        public SportTypeModel Sports { get; set; }
        public SportLevelModel Level { get; set; }

    }


}