﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace stormpath_angularjs_dotnet_stripe_twilio.Models
{
    public class SMSSettings
    {
        public string Sid { get; set; }
        public string Token { get; set; }
        public string BaseUri { get; set; }
        public string RequestUri { get; set; }
        public string From { get; set; }
    }
}
