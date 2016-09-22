using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CoPlayV2.Models
{
    public class MyManageIndexViewModels
    {
        public MyUser CurrentUser { get; set; }
        public List<MyMessage> sentMessages { get; set; }
        public List<MyMessage> receivedMessages { get; set; }

        public List<UserSportPerformance> userPerformances { get; set; }

        [Display(Name = "Badminton performance")]
        public SportLevelEnum BadmintonPf { get; set; }
        [Display(Name = "Fitness performance")]
        public SportLevelEnum FitnessPf { get; set; }
        [Display(Name = "Squash performance")]
        public SportLevelEnum SquashPf { get; set; }

        [Display(Name = "Swimming performance")]
        public SportLevelEnum SwimmingPf { get; set; }

        [Display(Name = "Table tennis performance")]
        public SportLevelEnum TabletennisPf { get; set; }

        [Display(Name = "Tennis outdoor performance")]
        public SportLevelEnum TennisOdpf { get; set; }

        [Display(Name = "Tennis indoor performance")]
        public SportLevelEnum TennisIdpf { get; set; }
    }



    public class MyMessage
    {
        public InternalMessage message { get; set; }
        public ApplicationUser sender { get; set; }
        public ApplicationUser receiver { get; set; }
    }
}