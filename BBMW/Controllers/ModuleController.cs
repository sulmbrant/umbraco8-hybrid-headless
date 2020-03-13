using BBMW.Classes;
using BBMW.DocumentTypes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web.Mvc;

namespace BBMW.Controllers
{
    public class ModuleController : SurfaceController
    {
        // GET: Module
        public ActionResult Index()
        {
            return View();
        }

        [ChildActionOnly]
        public ActionResult GetStandardBlock(StandardBlock content)
        {
            var contentModel = JsonHelper.GenerateJsonFromNestedContent((object)content);
            return PartialView("~/Views/Modules/_StandardBlock.cshtml", contentModel);
        }

        [ChildActionOnly]
        public ActionResult GetImageBlock(ImageBlock content)
        {
            var contentModel = JsonHelper.GenerateJsonFromNestedContent((object)content);
            return PartialView("~/Views/Modules/_ImageBlock.cshtml", contentModel);
        }
    }
}