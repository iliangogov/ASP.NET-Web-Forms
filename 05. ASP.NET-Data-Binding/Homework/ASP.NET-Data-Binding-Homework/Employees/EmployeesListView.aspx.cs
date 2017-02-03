using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Employees
{
    public partial class EmployeesListView : System.Web.UI.Page
    {
        private NorthwindEntities northwindContext = new NorthwindEntities();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.Page.IsPostBack)
            {
                this.EmployeesListViewForm.DataSource = this.northwindContext.Employees.ToList();
                this.EmployeesListViewForm.DataBind();
            }
        }
    }
}