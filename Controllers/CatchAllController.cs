using Microsoft.AspNetCore.Mvc;

namespace DynamicCatchAllRouteDemo.Controllers
{
	public class CatchAllController : Controller
	{
		// GET
		public IActionResult Index()
		{
			return Content("catch all");
		}

		public IActionResult HandleWrongPath()
		{
			return Content("this is wrong path");
		}
	}
}