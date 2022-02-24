using Microsoft.AspNetCore.Mvc;

namespace DynamicCatchAllRouteDemo.Controllers
{
	public class FooController : Controller
	{
		// GET
		public IActionResult Index()
		{
			return Content("foo");
		}
	}
}