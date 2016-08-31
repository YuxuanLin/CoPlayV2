using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CoPlayV2.Models
{
    public class MatchIndexViewModels
    {

        public SportTypeModel Sports { get; set; }

        public SportLevelModel Level { get; set; }
        public List<MyUser> users { get; set; }

        public IList<UserLoginInfo> CurrentLogins { get; set; }
        public IList<AuthenticationDescription> OtherLogins { get; set; }
    }

    public class MyUser
    {
        public ApplicationUser user { get; set; }
        public List<Event> events { get; set; }
    }
}