using System;

namespace RandomNumbers
{
    public partial class RandomNumbersWeb : System.Web.UI.Page
    {
        private Random random = new Random();
        private const string BadInput = "Incorrect numbers!";

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void SubmittButton_Click(object sender, EventArgs e)
        {
            int temp;

            try
            {
                int firstNumber = int.Parse(this.FirstNumberInput.Text);
                int secondNumber = int.Parse(this.SecondNumberInput.Text);
              
                if (firstNumber > secondNumber)
                {
                    temp = secondNumber;
                    secondNumber = firstNumber;
                    firstNumber = temp;
                }

                this.ResultInput.Text = this.random.Next(firstNumber, secondNumber + 1).ToString();
            }
            catch (Exception)
            {
                this.ResultInput.Text = BadInput;
            }
        }
    }
}