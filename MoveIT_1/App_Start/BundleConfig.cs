using System.Web;
using System.Web.Optimization;

namespace MoveIT_1
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/site.css"));
            bundles.Add(new ScriptBundle("~/bundles/MoveIT_1")
                .IncludeDirectory("~/Scripts/Controllers", "*.js")
                .IncludeDirectory("~/Scripts/Factories", "*.js")
                .Include("~/Scripts/MoveIT_1.js")); 

            BundleTable.EnableOptimizations = true;
        }
    }
}
