using System.Web.Mvc;

namespace martensson.com.Controllers
{
	public class HomeController : Controller
	{
		// GET: Home
		public ActionResult Index()
		{
			return View();
		}
	}
}