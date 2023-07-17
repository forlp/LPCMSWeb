using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LPCMSWeb.Models
{
    public class Admintrator
    {
        public int ID { set; get; }
        public string Name { set; get; }
        public string Password { set; get; }
        public string Email { set; get; }
        public string Phone { set; get; }
        public DateTime AddTime { set; get; }
        public bool Sstatus { get; set; }
    }
}