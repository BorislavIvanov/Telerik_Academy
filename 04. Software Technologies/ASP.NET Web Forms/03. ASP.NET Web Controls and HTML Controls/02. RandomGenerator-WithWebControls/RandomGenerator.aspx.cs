using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _02.RandomGenerator_WithWebControls
{
    public partial class RandomGenerator : System.Web.UI.Page
    {
        private readonly Random randomGenerator = new Random();

        protected void btnGenerate_Click(object sender, EventArgs e)
        {
            int minValue = default(int);
            string minValueInput = tbMin.Text;
            bool minValueIsNumber = int.TryParse(minValueInput, out minValue);

            if (!minValueIsNumber || String.IsNullOrEmpty(minValueInput))
            {
                litGeneratedNumber.Text = "Invalid Min value!!!";
                return;
            }

            int maxValue = default(int);
            string maxValueInput = tbMax.Text;
            bool maxValueIsNumber = int.TryParse(maxValueInput, out maxValue);

            if (!maxValueIsNumber || String.IsNullOrEmpty(maxValueInput))
            {
                litGeneratedNumber.Text = "Invalid Max value!!!";
                return;
            }

            if (minValue > maxValue)
            {
                litGeneratedNumber.Text = "minValue must be less than maxValue!!!";
                return;
            }

            if (minValueIsNumber && maxValueIsNumber)
            {
                int randomNumber = randomGenerator.Next(minValue, maxValue + 1);
                litGeneratedNumber.Text = randomNumber.ToString();
            }
        }
    }
}