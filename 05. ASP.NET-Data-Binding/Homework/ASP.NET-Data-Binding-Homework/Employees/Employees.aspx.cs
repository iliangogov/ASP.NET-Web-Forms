using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Employees
{
    public partial class Employees : System.Web.UI.Page
    {
        private NorthwindEntities northwindContext = new NorthwindEntities();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.Page.IsPostBack)
            {
                this.EmployeesGridView.DataSource = this.northwindContext.Employees.Select(x => new
                {
                    EmployeeID = x.EmployeeID,
                    FirstName = x.FirstName,
                    LastName = x.LastName,
                    HomePhone = x.HomePhone
                }).ToList();

                this.EmployeesGridView.DataBind();
            }
        }
    }
}