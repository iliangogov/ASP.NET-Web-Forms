using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _01.Registration_Form
{
    public partial class Registration : System.Web.UI.Page
    {
        public void CreateUser_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Success.aspx");
        }

        protected void Page_Load(object sender, EventArgs e)
        {
        }
    }
}