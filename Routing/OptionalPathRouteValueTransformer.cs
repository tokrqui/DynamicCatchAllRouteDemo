using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.AspNetCore.Routing;

namespace DynamicCatchAllRouteDemo.Routing
{
	public class OptionalPathRouteValueTransformer : DynamicRouteValueTransformer
	{
		public override ValueTask<RouteValueDictionary> TransformAsync(
			HttpContext httpContext,
			RouteValueDictionary values)
		{
			values["controller"] = "OptionalPath";
			values["action"] = "Index";
			
			return new ValueTask<RouteValueDictionary>(values);
		}
		
	}
}