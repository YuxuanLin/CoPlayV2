namespace CoPlayV2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Event
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Event()
        {
            Rates = new HashSet<Rate>();
        }

        public int Id { get; set; }

        [Required]
        public string Sport { get; set; }

        [Required]
        [StringLength(50)]
        public string StartTime { get; set; }

        [Required]
        [StringLength(50)]
        public string FinishTime { get; set; }

        [StringLength(128)]
        public string Other { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Rate> Rates { get; set; }

        [Required]
        [StringLength(128)]
        public string UserID { get; set; }
    }
}
