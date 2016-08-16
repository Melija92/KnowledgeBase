using System.Linq;
using System.Web.Mvc;

namespace KnowledgeBase.Controllers
{
    public class HomeController : Controller
    {
        

        public JsonResult AutoCompleteArticles(string term)
        {
            var result = KBArticles.GetListArticles().ToList().Where(m => m.ArticleName.ToLower().Contains(term.ToLower()));
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Index()
        {
            
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}