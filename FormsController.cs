using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCLogin.Controllers
{
    public class FormsController : Controller
    {
        // GET: Forms
        public ActionResult Index()
        {
            return View();
        }

        public RedirectResult RedirectToAspx()
        {
            return Redirect("~/WebForms/Index.aspx");
        }
    }
}