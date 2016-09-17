using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CoPlayV2.Models
{
    public class MyManageIndexViewModels
    {
        public MyUser currentUser { get; set; }
        public List<InternalMessage> sentMessages { get; set; }
        public List<InternalMessage> receivedMessages { get; set; }

    }
}