using System.Web;
using System.Web.Optimization;


namespace TwitterPage
{
    public class BundleConfig
    {
        
        public static void RegisterBundles(BundleCollection bundles)
        {

            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-1.11.0.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));



            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/css/screen.css"));




        }
    }
}