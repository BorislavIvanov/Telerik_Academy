using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _01.Hello
{
    public partial class HelloPage : System.Web.UI.Page
    {
        protected void btnGenerate_Click(object sender, EventArgs e)
        {
            string inputName = tbInputName.Text.ToString();

            if (String.IsNullOrEmpty(inputName))
            {
                litResult.Text = "Hello \"Anonymous\" :)";
            }
            else
            {
                litResult.Text = "Hello " + inputName;
            }
        }
    }
}