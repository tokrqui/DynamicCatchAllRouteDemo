using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.AspNetCore.Routing;

namespace DynamicCatchAllRouteDemo.Routing
{
	public class CatchAllRouteValueTransformer : DynamicRouteValueTransformer
	{
		public override ValueTask<RouteValueDictionary> TransformAsync(
			HttpContext httpContext,
			RouteValueDictionary values)
		{
			if (values.TryGetValue("path", out var pathValue))
			{
				if (pathValue is string path)
				{
					if (path == "catch-all")
					{
						values["controller"] = "CatchAll";
						values["action"] = "Index";
					}
					if (path == "known/wrong/path")
					{
						values["controller"] = "CatchAll";
						values["action"] = "HandleWrongPath";
					}
				}
			}

			return new ValueTask<RouteValueDictionary>(values);
		}
	}
}