using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Security.Principal;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.AspNet.Identity;

namespace Countries.Web
{
    public partial class Site : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Unnamed_LoggingOut(object sender, LoginCancelEventArgs e)
        {
            Context.GetOwinContext().Authentication.SignOut(DefaultAuthenticationTypes.ApplicationCookie);
        }

        protected void NavigationMenu_MenuItemDataBound(object sender, MenuEventArgs e)
        {
            if (ShouldRemoveItem(e.Item.Text))
            {
                e.Item.Parent.ChildItems.Remove(e.Item);
            }
        }

        private bool ShouldRemoveItem(string menuText)
        {
            var isAuthenticated = Context.User.Identity.IsAuthenticated;

            if (menuText == "Users" && !isAuthenticated)
            {
                return true;
            }

            if (menuText == "My events" && !isAuthenticated)
            {
                return true;
            }

            return false;
        }
    }
}