using Microsoft.AspNetCore.Mvc;

namespace DynamicCatchAllRouteDemo.Controllers
{
	public class OptionalPathController : Controller
	{
		// GET
		public IActionResult Index()
		{
			return Content("optional path");
		}
	}
}