using System;
using System.Web;

namespace WebControlsHomework
{
    public partial class Escaping : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void OnSubmitButtonClicked(object sender, EventArgs e)
        {
            var enteredText = System.Security.SecurityElement.Escape(this.mainTextBox.Text);

            this.enteredTextBox.Text = enteredText;
            this.enteredTextLabel.Text = enteredText;
        }
    }
}