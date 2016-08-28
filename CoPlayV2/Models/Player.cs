namespace CoPlayV2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Player
    {
        public int Id { get; set; }

        public int EventID { get; set; }

        [Required]
        [StringLength(128)]
        public string UserID { get; set; }
    }
}
