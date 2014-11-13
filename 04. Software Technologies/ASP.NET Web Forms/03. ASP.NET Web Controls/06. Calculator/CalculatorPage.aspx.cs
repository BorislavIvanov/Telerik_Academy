using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _06.Calculator
{
    public partial class CalculatorPage : System.Web.UI.Page
    {
        protected void DigitButtonClicked(object sender, EventArgs e)
        {
            var input = sender as Button;
            string inputValue = input.Text;

            if (currentOperator.Text == "")
            {
                if (numOne.Text.Length < 18)
                {
                    numOne.Text += inputValue;    
                }
                
                litResultScreen.Text = numOne.Text;
            }
            else
            {
                if (numTwo.Text.Length < 18)
                {
                    numTwo.Text += inputValue;
                }

                litResultScreen.Text = numTwo.Text;
            }
        }

        protected void OperatorClicked(object sender, EventArgs e)
        {
            var selectedOperator = sender as Button;
            string operatorSign = selectedOperator.Text;

            currentOperator.Text = operatorSign;
        }

        protected void RootClicked(object sender, EventArgs e)
        {
            double firstNumber = double.Parse(numOne.Text);

            double result = Math.Sqrt(firstNumber);

            litResultScreen.Text = result.ToString();

            numOne.Text = result.ToString();
        }

        protected void ClearClicked(object sender, EventArgs e)
        {
            litResultScreen.Text = "";
            numOne.Text = "";
            numTwo.Text = "";
        }

        protected void resultButtonClicked(object sender, EventArgs e)
        {
            if (currentOperator.Text != "")
            {
                string currentOperatorSign = currentOperator.Text;
                decimal firstNumber = decimal.Parse(numOne.Text);
                decimal secondNumber = decimal.Parse(numTwo.Text);

                decimal result = default(decimal);

                switch (currentOperatorSign)
                {
                    case "+": result = firstNumber + secondNumber; break;
                    case "-": result = firstNumber - secondNumber; break;
                    case "x": result = firstNumber * secondNumber; break;
                    case "/": result = firstNumber / secondNumber; break;
                    default: break;
                }

                litResultScreen.Text = result.ToString();

                numOne.Text = result.ToString();
                numTwo.Text = "";
                currentOperator.Text = "";
            }
        }
    }
}