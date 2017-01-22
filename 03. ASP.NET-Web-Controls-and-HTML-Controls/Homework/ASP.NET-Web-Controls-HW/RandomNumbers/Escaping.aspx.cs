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
            var enteredText = this.mainTextBox.Text;
            var decoded = System.Security.SecurityElement.Escape(enteredText);

            this.enteredTextBox.Text = decoded;
            this.enteredTextLabel.Text = decoded;
        }
    }
}