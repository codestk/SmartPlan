using SmartPlanControl.Models;
using System.Web.Mvc;

namespace SmartPlanControl.Controllers
{
    public class Model1Controller : Controller
    {
        // GET: Model1
        public ActionResult Index()
        {
            return View(certeModel());
        }

        private static Model1 certeModel()
        {
            //var item = RenderingContext.Current.ContextItem;

            //var model1 = new Model1() { Title = new HtmlString(FeedRenderer.RenderField(item, "Title")) };
            var model1 = new Model1();// { Title = new HtmlString("PPPPPP") };

            return model1;
        }
    }
}