using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LPCMSWeb.ViewModels
{
    public class AdmintratorAddInfo
    {
        [Required]
        public string Name { set; get; }
        [Required]
        public string Password { set; get; }
        public string ValidateCode { set; get; }

    }
}