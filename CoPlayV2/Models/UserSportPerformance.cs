namespace CoPlayV2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserSportPerformance")]
    public partial class UserSportPerformance
    {
        public int Id { get; set; }

        [Required]
        [StringLength(128)]
        public string UserID { get; set; }

        [Required]
        [StringLength(10)]
        public string Level { get; set; }

        [Required]
        public string Sport { get; set; }
    }
}
