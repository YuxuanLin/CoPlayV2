using System.Web;
using System.Web.Optimization;

namespace CoPlayV2
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/bundles/layout/css").Include(
                      "~/Content/bootstrap.css", // Bootstrap
                      "~/Content/UIcss/animate.css",// Animation
                      "~/Content/UIcss/owl.theme.css", // Theme
                      "~/Content/UIcss/owl.carousel.css", // Theme
                      "~/Content/UIcss/style.css",
                      "~/Content/UIcss/Fixfooter.css"//Fixed footer css
                        ).Include("~/Content/UIcss/font-awesome.min.css", new CssRewriteUrlTransform())
                        );

            bundles.Add(new StyleBundle("~/bundles/uicss").Include(
                "~/Content/UIcss/bootstrap.min.css",
                "~/Content/UIcss/animate.css",
                "~/Content/UIcss/font-awesome.min.css",
                "~/Content/UIcss/owl.theme.css",
                "~/Content/UIcss/owl.carousel.css",
                "~/Content/UIcss/style.css"
            ));

            bundles.Add(new ScriptBundle("~/bundles/scripts").Include(
               "~/Scripts/jquery.js",
               "~/Scripts/bootstrap.min.js",
               "~/Scripts/jquery.parallax.js",
               "~/Scripts/jquery.nav.js",
               "~/Scripts/jquery.backstretch.min.js",
               "~/Scripts/owl.carousel.min.js",
               "~/Scripts/smoothscroll.js",
               "~/Scripts/wow.min.js",
               "~/Scripts/custom.js"
            ));

            bundles.Add(new StyleBundle("~/bundles/search").Include(
                        "~/Content/UIcss/sportspotssearch.css"));

            bundles.Add(new StyleBundle("~/bundles/aboutus").Include(
                        "~/Content/aboutus.css"));

            bundles.Add(new StyleBundle("~/bundles/MATCHcss").Include(
                      "~/Content/UIcss/MATCHcss.css"));

            bundles.Add(new StyleBundle("~/bundles/logincss").Include(
                      "~/Content/UIcss/logincss.css"));

            bundles.Add(new StyleBundle("~/bundles/registercss").Include(
                      "~/Content/UIcss/registercss.css"));

            bundles.Add(new StyleBundle("~/bundles/matchIndexCss").Include(
                      "~/Content/UIcss/matchIndex.css"));

            bundles.Add(new StyleBundle("~/bundles/ManageCss").Include(
                      "~/Content/UIcss/manageIndex.css"));

            bundles.Add(new StyleBundle("~/bundles/CLUBcss").Include(
                      "~/Content/UIcss/Clubcss.css"));
            bundles.Add(new StyleBundle("~/bundles/jqueryUIcss").Include(
                     "~/Content/UIcss/jquery-ui.css"));
            bundles.Add(new ScriptBundle("~/bundles/CLUBscripts").Include(
               "~/Scripts/jquery.js",
               "~/Scripts/jquery-ui.js",
               "~/Scripts/Clubjs.js"
            ));
            bundles.Add(new ScriptBundle("~/bundles/facilityscripts").Include(
               "~/Scripts/facilityMap.js"
            ));
            bundles.Add(new StyleBundle("~/bundles/searchClubIndex").Include(
                      "~/Content/UIcss/searchClubIndex.css"));

            bundles.Add(new StyleBundle("~/bundles/sportSearch").Include(
                      "~/Content/UIcss/sportSearch.css"));

            bundles.Add(new StyleBundle("~/bundles/sportSearch").Include(
          "~/Content/UIcss/sportSearch.css"));
        }
    }
}
