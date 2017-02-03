using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Employees
{
    public partial class EmployeesFormView : System.Web.UI.Page
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
                    HomePhone = x.HomePhone,
                    City = x.City
                }).ToList();

                this.EmployeesGridView.DataBind();
                this.CheckForSelectedEmployee();
            }

        }

        private void CheckForSelectedEmployee()
        {
            int employeeId;
            if (!int.TryParse(this.Request.Params["id"], out employeeId))
            {
                this.SelectedEmployeeContainer.Visible = false;
                return;
            }

            var employee = this.northwindContext.Employees.Find(employeeId);
            if (employee == null)
            {
                this.SelectedEmployeeContainer.Visible = false;
                return;
            }

            this.EmployeeFormView.DataSource = new List<Employee>() { employee };
            this.EmployeeFormView.DataBind();
            this.SelectedEmployeeContainer.Visible = true;
        }
    }
}