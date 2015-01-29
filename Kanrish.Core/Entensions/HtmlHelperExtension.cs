using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using System.Web;
using KanrishaEF;

namespace Kanrish.Core.Entensions
{
    public static class HtmlHelperExtension
    {
        public static MvcHtmlString NavigationMenu(this HtmlHelper helper)
        {
            HttpContext context = HttpContext.Current;
            TB_UserProfile role = (TB_UserProfile)context.Session["UserSession"];
            StringBuilder navigationBuilder = new StringBuilder();

            navigationBuilder.Append("<aside class=\"sidebar\">");
            navigationBuilder.Append("<ul class=\"tab_nav\">");
            navigationBuilder.Append("<li class=\"active_tab i_32_dashboard\">");
            navigationBuilder.Append("<a href=\"index.html\" title=\"General Info\">");
            navigationBuilder.Append("<span class=\"tab_label\">Dashboard</span>");
            navigationBuilder.Append("<span class=\"tab_info\">General Info</span></a></li><li class=\"i_32_inbox\"><a href=\"inbox.html\" title=\"Your Messages\"><span class=\"tab_label\">Inbox</span><span class=\"tab_info\">Your Messages</span></a></li>");
            if (role.TB_Role.Role == "admin")
            {
                navigationBuilder.Append("<li class=\"i_32_charts\"><a href=\"charts.html\" title=\"Visual Data\"><span class=\"tab_label\">Charts</span><span class=\"tab_info\">Visual Data</span></a></li>");
                navigationBuilder.Append("<li class=\"i_32_ui\"><a href=\"ui.html\" title=\"Kit elements\"><span class=\"tab_label\">UI</span><span class=\"tab_info\">Kit elements</span></a></li>");
                navigationBuilder.Append("<li class=\"i_32_tables\"><a href=\"tables.html\" title=\"Some Rows\"><span class=\"tab_label\">Tables</span><span class=\"tab_info\">Some Rows</span></a></li>");
                navigationBuilder.Append("<li class=\"i_32_forms\"><a href=\"forms.html\" title=\"Some Fields\"><span class=\"tab_label\">Forms</span><span class=\"tab_info\">Some Fields</span></a></li>");
            }
            navigationBuilder.Append("</ul></aside>");


            return new MvcHtmlString(navigationBuilder.ToString());

        }

        public static MvcHtmlString AdminHRMenu(this HtmlHelper helper)
        {
            HttpContext context = HttpContext.Current;
            TB_UserProfile role = (TB_UserProfile)context.Session["UserSession"];
            StringBuilder navigationBuilder = new StringBuilder();

            if (role.TB_Role.Role == "Admin")
            {
                navigationBuilder.Append("<li id=\"Worker\" class=\"i_32_inbox\"><a href=\"\\Home\\GetUsers\" title=\"Manage Worker\"><span class=\"tab_label\">Worker</span></a></li>");
            }
            
            return new MvcHtmlString(navigationBuilder.ToString());

        }
    }
}
