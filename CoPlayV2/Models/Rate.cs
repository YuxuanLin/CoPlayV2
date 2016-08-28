namespace CoPlayV2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Rate
    {
        public int Id { get; set; }

        public int EventID { get; set; }

        [Required]
        [StringLength(128)]
        public string RaterID { get; set; }

        [Required]
        [StringLength(128)]
        public string RatedID { get; set; }

        [Required]
        [StringLength(10)]
        public string Level { get; set; }

        [Required]
        public string Sport { get; set; }

        public virtual Event Event { get; set; }
    }
}
