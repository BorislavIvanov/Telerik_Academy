using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _01.RandomGenerator_WithHTMLControls
{
    public partial class RandomGenerator : System.Web.UI.Page
    {
        private readonly Random randomGenerator = new Random();

        protected void btnGenerate_ServerClick(object sender, EventArgs e)
        {
            int minValue = default(int);
            string minValueInput = inpMin.Value;
            bool minValueIsNumber = int.TryParse(minValueInput, out minValue);

            if (!minValueIsNumber || String.IsNullOrEmpty(minValueInput))
            {
                divGeneratedNumber.InnerHtml = "Invalid Min value!!!";
                return;
            }

            int maxValue = default(int);
            string maxValueInput = inpMax.Value;
            bool maxValueIsNumber = int.TryParse(maxValueInput, out maxValue);

            if (!maxValueIsNumber || String.IsNullOrEmpty(maxValueInput))
            {
                divGeneratedNumber.InnerHtml = "Invalid Max value!!!";
                return;
            }

            if (minValue > maxValue)
            {
                divGeneratedNumber.InnerHtml = "minValue must be less than maxValue!!!";
                return;
            }

            if (minValueIsNumber && maxValueIsNumber)
            {
                int randomNumber = randomGenerator.Next(minValue, maxValue + 1);
                divGeneratedNumber.InnerHtml = randomNumber.ToString();
            }
        }
    }
}