using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace CoPlayV2.Models
{
    public class ClubModel
    {
        public int Id { get; set; }

        public string Type { get; set; }
        public string SportType { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public string Contact { get; set; }
        public string TraningTime { get; set; }
        public string Website { get; set; }

    }
}