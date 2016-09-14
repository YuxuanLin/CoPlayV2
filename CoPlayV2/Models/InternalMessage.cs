using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CoPlayV2.Models
{
    public class InternalMessage
    {
        public int Id { get; set; }

        [Required]
        [StringLength(128)]
        public string SenderID { get; set; }

        [Required]
        [StringLength(128)]
        public string ReceiverID { get; set; }

        [Required]
        public  int Status { get; set; }
 
        public string Message { get; set; }

    }
}