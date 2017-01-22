using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Hello
{
    public partial class Hello : System.Web.UI.Page
    {
        private string location = Assembly.GetExecutingAssembly().Location;

        protected void Page_Load(object sender, EventArgs e)
        {
            this.Notifier.Attributes.Add("class","hidden");
            this.CodeBehindHello.InnerText = "Hello ASP.NET from the C# code.";
            this.CurrentLocation.InnerText = string.Format("Current location: {0}", location);
        }

        protected void NameButton_Click(object sender, EventArgs e)
        {
            this.Notifier.Attributes.Remove("class");
            string name = this.NameInput.Text;
            string message = string.Format("Hello {0}!", name);
            this.Notifier.InnerText = message;
        }
    }
}