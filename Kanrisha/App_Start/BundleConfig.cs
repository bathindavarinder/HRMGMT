using System.Web;
using System.Web.Optimization;

namespace Kanrisha
{
    public class BundleConfig
    {
        // For more information on Bundling, visit http://go.microsoft.com/fwlink/?LinkId=254725
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"
                        ));

            bundles.Add(new ScriptBundle("~/bundles/jqueryui").Include(
                        "~/Scripts/jquery-ui-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.unobtrusive*",
                        "~/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/Kjquery").Include(
                        "~/Scripts/Flot/jquery.flot.js",
                        "~/Scripts/Flot/jquery.flot.resize.js",
                        "~/Scripts/Flot/jquery.flot.pie.js",
                        "~/Scripts/DataTables/jquery.dataTables.js",
                        "~/Scripts/ColResizable/colResizable-1.3.js",
                        "~/Scripts/jquery-ui-{version}.js",
                        "~/Scripts/Uniform/jquery.uniform.js",
                        "~/Scripts/Tipsy/jquery.tipsy.js",
                        "~/Scripts/Elastic/jquery.elastic.js",
                        "~/Scripts/ColorBox/jquery.colorbox.js",
                        "~/Scripts/SuperTextarea/jquery.supertextarea.js",
                        "~/Scripts/UISpinner/ui.spinner.js",
                        "~/Scripts/MaskedInput/jquery.maskedinput-1.3.js",
                        "~/Scripts/ClEditor/jquery.cleditor.js",
                        "~/Scripts/FullCalendar/fullcalendar.js",
                        "~/Scripts/ColorPicker/colorpicker.js",
                        "~/Scripts/kanrisha.js"
                        ));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new StyleBundle("~/Content/css").Include("~/Content/style.css"));
            bundles.Add(new StyleBundle("~/Content/sitecss").Include("~/Content/Site.css"));

            bundles.Add(new StyleBundle("~/Content/kanrishacss").Include(
                "~/Content/tipsy",
                "~/Content/normalize.css",
                "~/Content/jquery.cleditor.css",
                "~/Content/fullcalendar.css",
                "~/Content/colorpicker.css",
                "~/Content/colorbox.css"
                ));

            bundles.Add(new StyleBundle("~/Content/themes/base/css").Include(
                        "~/Content/themes/base/jquery.ui.core.css",
                        "~/Content/themes/base/jquery.ui.resizable.css",
                        "~/Content/themes/base/jquery.ui.selectable.css",
                        "~/Content/themes/base/jquery.ui.accordion.css",
                        "~/Content/themes/base/jquery.ui.autocomplete.css",
                        "~/Content/themes/base/jquery.ui.button.css",
                        "~/Content/themes/base/jquery.ui.dialog.css",
                        "~/Content/themes/base/jquery.ui.slider.css",
                        "~/Content/themes/base/jquery.ui.tabs.css",
                        "~/Content/themes/base/jquery.ui.datepicker.css",
                        "~/Content/themes/base/jquery.ui.progressbar.css",
                        "~/Content/themes/base/jquery.ui.theme.css"));
        }
    }
}