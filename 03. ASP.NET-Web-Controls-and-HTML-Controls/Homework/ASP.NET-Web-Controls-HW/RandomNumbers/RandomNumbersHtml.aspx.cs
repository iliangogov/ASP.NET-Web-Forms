using System;

namespace RandomNumbers
{
    public partial class RandomNumbersHtml : System.Web.UI.Page
    {
        private Random randomNumberGenerator = new Random();
        private const string BadInput = "Incorrect Numbers!";
        private const string ResultMessage = "Your Random number: ";

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void OnSubmitButton_Click(object sender, EventArgs e)
        {
            try
            {
                int minNumber = int.Parse(this.minNumberInput.Value);
                int maxNumber = int.Parse(this.maxNumberInput.Value);

                int randomNumber = randomNumberGenerator.Next(minNumber, maxNumber + 1);
                this.randomNumberContainer.InnerText = string.Format("{0}{1}", ResultMessage, randomNumber.ToString());
            }
            catch (Exception)
            {
                //handled in html forms allready! Works if min number > max number :)
                this.randomNumberContainer.InnerText = BadInput;
            }
        }
    }
}