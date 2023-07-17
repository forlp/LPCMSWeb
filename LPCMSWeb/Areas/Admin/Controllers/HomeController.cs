using LPCMSWeb.Cores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LPCMSWeb.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        // GET: Admin/Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        public FileResult GetValidateCode()
        {
            //byte[] bytes = null;
            //return this.File(bytes,@"image/jpeg");
            ValidateCodeHelper validateCode = new ValidateCodeHelper();
            return this.File(validateCode.Page_Load(), @"image/jpeg");
        }
    }
}