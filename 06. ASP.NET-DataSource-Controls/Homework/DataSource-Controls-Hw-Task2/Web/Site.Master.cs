using System;
using System.Web.UI.HtmlControls;

namespace Todos.Web
{
    public partial class Site : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        public void ShowSuccessMessage(string message)
        {
            this.success.InnerText = message;
            this.success.Attributes.Remove("hidden");
        }

        public void ShowErrorMessage(string message)
        {
            this.error.InnerText = message;
            this.error.Attributes.Remove("hidden");
        }
    }
}