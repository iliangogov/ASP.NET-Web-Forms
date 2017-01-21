using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SumatorWebForms
{
    public partial class Sumator : System.Web.UI.Page
    {
        private const string BadInput = "Incorrect Numbers!";

        protected void CalculateSum_Click(object sender, EventArgs e)
        {
            this.Notifier.Attributes.Add("class","hidden");

            try
            {
                int firstOperand = int.Parse(this.FirstNumberInput.Text);
                int secondOperand = int.Parse(this.SecondNumberInput.Text);

                this.ResultInput.Text = (firstOperand + secondOperand).ToString();
            }
            catch (Exception)
            {
                this.Notifier.InnerText = BadInput;
                this.Notifier.Attributes.Remove("class");
            }
        }

        protected void ClearForm_Click(object sender, EventArgs e)
        {
            this.FirstNumberInput.Text = string.Empty;
            this.SecondNumberInput.Text = string.Empty;
            this.ResultInput.Text = string.Empty;
            this.Notifier.Attributes.Add("class", "hidden");
        }
    }
}