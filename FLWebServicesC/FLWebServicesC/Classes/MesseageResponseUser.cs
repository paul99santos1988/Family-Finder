﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FLWebServicesC.Classes
{
    public class MesseageResponseUser
    {
        public string UserUID { get; set; }
        public string Message { get; set; }
        public string PhoneUID { get; set; }
        public int ErrorID { get; set; } // give id if there is error

    }
}