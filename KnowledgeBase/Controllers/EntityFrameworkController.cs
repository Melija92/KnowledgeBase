using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;

namespace KnowledgeBase.Controllers
{
    public class EntityFrameworkController : Controller
    {
        // GET: EntityFramework
        [OutputCache(Duration = 3600, VaryByParam = "none", Location = OutputCacheLocation.Client, NoStore = true)]
        public ActionResult Index()
        {
            return View();
        }

        [OutputCache(Duration = 3600, VaryByParam = "none", Location = OutputCacheLocation.Client, NoStore = true)]
        public ActionResult Linq()
        {
            return View();
        }

        [OutputCache(Duration = 3600, VaryByParam = "none", Location = OutputCacheLocation.Client, NoStore = true)]
        public ActionResult CodeFirstwithEntityFramework()
        {
            return View();
        }

        [OutputCache(Duration = 3600, VaryByParam = "none", Location = OutputCacheLocation.Client, NoStore = true)]
        public ActionResult AuditingwithEntityFramework()
        {
            return View();
        }

        [OutputCache(Duration = 3600, VaryByParam = "none", Location = OutputCacheLocation.Client, NoStore = true)]
        public ActionResult CreatingModeFirstwithEntityFramework()
        {
            return View();
        }

        [OutputCache(Duration = 3600, VaryByParam = "none", Location = OutputCacheLocation.Client, NoStore = true)]
        public ActionResult LoadingObjectsinEntityFramework()
        {
            return View();
        }

        [OutputCache(Duration = 3600, VaryByParam = "none", Location = OutputCacheLocation.Client, NoStore = true)]
        public ActionResult EntityFramework()
        {
            return View();
        }

        [OutputCache(Duration = 3600, VaryByParam = "none", Location = OutputCacheLocation.Client, NoStore = true)]
        public ActionResult InheritanceWithEntityFramework()
        {
            return View();
        }
    }
}