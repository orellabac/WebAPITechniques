using System.Diagnostics;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace WebApiValidationDemo.Filters
{
    public class StopwatchAttribute : ActionFilterAttribute
    {
        private const string StopwatchKey = "StopwatchFilter.Value";
        public override void OnActionExecuting(HttpActionContext actionContext)
        {
            base.OnActionExecuting(actionContext);
            actionContext.Request.Properties[StopwatchKey] = Stopwatch.StartNew();
        }
        public override void OnActionExecuted(HttpActionExecutedContext actionExecutedContext)
        {
            base.OnActionExecuted(actionExecutedContext);
            Stopwatch stopwatch = (Stopwatch)actionExecutedContext.Request.Properties[StopwatchKey];
            // TODO something useful with stopwatch.Elapsed
            Debug.WriteLine("Elapsed = " + stopwatch.ElapsedTicks);
        }
    }
}