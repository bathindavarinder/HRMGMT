using KanrishaEF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace Kanrish.Core.Attribute
{
    public class CustomAuthorizeAttribute : AuthorizeAttribute
    {
        
        private readonly string[] allowedroles;
        public CustomAuthorizeAttribute(params string[] roles)
        {
            this.allowedroles = roles;
        }
        protected override bool AuthorizeCore(HttpContextBase httpContext)
        {
            bool authorize = false;

            HttpContext context = HttpContext.Current;
            TB_UserProfile role = (TB_UserProfile)context.Session["UserSession"];
            if (role == null)
            {
                return authorize;
            }
            if (this.allowedroles.Contains(role.TB_Role.Role))
            {
                authorize = true;
            }


         
            return authorize;
        }
        protected override void HandleUnauthorizedRequest(AuthorizationContext filterContext)
        {
            filterContext.Controller.ViewBag.error = "error";
            filterContext.Result = new HttpUnauthorizedResult();
        }
    }  
}
