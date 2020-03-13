using BBMW.DocumentTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Umbraco.Web.Mvc;

namespace BBMW.Controllers
{
    public class StartController : SurfaceController
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}