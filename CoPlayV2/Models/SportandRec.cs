namespace CoPlayV2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SportandRec")]
    public partial class SportandRec
    {
        [StringLength(255)]
        public string X { get; set; }

        [StringLength(255)]
        public string Y { get; set; }

        [Key]
        [StringLength(255)]
        public string OBJECTID { get; set; }

        [StringLength(255)]
        public string Facility_ID { get; set; }

        [StringLength(255)]
        public string FacilityName { get; set; }

        [StringLength(255)]
        public string StreetNo { get; set; }

        [StringLength(255)]
        public string StreetName { get; set; }

        [StringLength(255)]
        public string StreetType { get; set; }

        [StringLength(255)]
        public string SuburbTown { get; set; }

        [StringLength(255)]
        public string Postcode { get; set; }

        [StringLength(255)]
        public string Latitude { get; set; }

        [StringLength(255)]
        public string Longitude { get; set; }

        [StringLength(255)]
        public string FaciltySportPlayedID { get; set; }

        [StringLength(255)]
        public string SportsPlayed { get; set; }

        [StringLength(255)]
        public string NumberFieldCourts { get; set; }

        [StringLength(255)]
        public string FieldSurfaceType { get; set; }

        [StringLength(255)]
        public string FacilityAge { get; set; }

        [StringLength(255)]
        public string FacilityCondition { get; set; }

        [StringLength(255)]
        public string FacilityUpgradeAge { get; set; }

        [StringLength(255)]
        public string Changerooms { get; set; }

        [StringLength(255)]
        public string LGA { get; set; }
    }
}
