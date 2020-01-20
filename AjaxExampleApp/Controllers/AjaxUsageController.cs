using System.Net;
using System.Web.Mvc;

namespace AjaxExampleApp.Controllers
{
    public class AjaxUsageController : Controller
    {
        // GET: AjaxUsage
        public ActionResult Index()
        {
            return View();
        }
       
        [HttpPost]
        public ActionResult GetValueContent()
        {
            return Content("Merhaba bu ajax için oluşturulmuş bir action'dır.");
        }
        
        [HttpPost]
        public ActionResult GetValueView()
        {
            return View("Test");
        }
      
        [HttpPost]
        public ActionResult GetBadRequest()
        {
            return new HttpStatusCodeResult(HttpStatusCode.GatewayTimeout);
        }
    }
}