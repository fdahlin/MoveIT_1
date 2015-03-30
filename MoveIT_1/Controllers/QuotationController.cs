using System.Web.Mvc;

namespace MoveIT_1.Controllers
{
    [Authorize]
    public class QuotationController : Controller
    {
        public ActionResult Present()
        {
            return View();
        }

        public ActionResult Submit()
        {
            return View();
        }
    }
}