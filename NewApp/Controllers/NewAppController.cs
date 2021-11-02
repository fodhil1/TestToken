using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewApp.Controllers
{
    public class NewAppController : Controller
    {
        // GET: NewApp
        public ActionResult Index()
        {
            return View();
        }
    }
}