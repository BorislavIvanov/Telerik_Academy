using System;

namespace _01.Calculator___ASP.NET_Web_Forms
{
    public partial class Calculator : System.Web.UI.Page
    {
        protected void submitButton_Click(object sender, EventArgs e)
        {
            string numberOneInput = tbFirstNumber.Text;
            int numberOne = default(int);

            bool numberOneIsNumberic = int.TryParse(numberOneInput, out numberOne);

            if (!numberOneIsNumberic || String.IsNullOrEmpty(numberOneInput))
            {
                litResult.Text = "Incorrect First Number!!!";
                return;
            }

            string numberTwoInput = tbSecondNumber.Text;
            int numberTwo = default(int);

            bool numberTwoIsNumberic = int.TryParse(numberTwoInput, out numberTwo);

            if (!numberTwoIsNumberic || String.IsNullOrEmpty(numberTwoInput))
            {
                litResult.Text = "Incorrect Second Number!!!";
                return;
            }

            litResult.Text = (numberOne + numberTwo).ToString();
        }
    }
}