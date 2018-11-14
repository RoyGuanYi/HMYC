using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Charm.NewWapApp.Models
{
    public class LoginModel
    {
        public string UserId { get; set; }

        public string UserPassword { get; set; }

        public string ReturnUrl { get; set; }
    }
}