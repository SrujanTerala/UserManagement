using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml;
using System.Net;
using System.Net.Mail;

namespace UserManagementSys.Models
{
    public class email
    {
        public int userid { get; set; }
       
        public UniqueId ActivationCode { get; set; }    

        public string Password { get; set; }
    }
}

