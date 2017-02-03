using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Employees
{
    public partial class EmployeesRepeater : System.Web.UI.Page
    {
        private NorthwindEntities northwindContext = new NorthwindEntities();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.Page.IsPostBack)
            {
                this.EmployeesRepeaterForm.DataSource = this.northwindContext.Employees.ToList();
                this.EmployeesRepeaterForm.DataBind();
            }
        }
    }
}