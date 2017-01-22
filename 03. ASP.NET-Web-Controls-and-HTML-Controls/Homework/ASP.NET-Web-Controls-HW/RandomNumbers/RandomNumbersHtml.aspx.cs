using System;

namespace WebControlsHomework
{
    public partial class RandomNumbersHtml : System.Web.UI.Page
    {
        private Random randomNumberGenerator = new Random();
        private const string BadInput = "Incorrect Numbers!";
        private const string ResultMessage = "Your Random number is: ";
        private const string CaughtMessage = "Even you swaped the numbers ";

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void OnSubmitButton_Click(object sender, EventArgs e)
        {
            this.randomNumberContainer.InnerText = string.Empty;

            try
            {
                int minNumber = int.Parse(this.minNumberInput.Value);
                int maxNumber = int.Parse(this.maxNumberInput.Value);
                int temp;

                if (minNumber > maxNumber)
                {
                    temp = maxNumber;
                    maxNumber = minNumber;
                    minNumber = temp;
                    this.randomNumberContainer.InnerText = CaughtMessage;
                }

                int randomNumber = randomNumberGenerator.Next(minNumber, maxNumber + 1);
                this.randomNumberContainer.InnerText += string.Format("{0}{1}", ResultMessage, randomNumber.ToString());
            }
            catch (Exception)
            {
                //handled in html forms allready!
                this.randomNumberContainer.InnerText = BadInput;
            }
        }
    }
}