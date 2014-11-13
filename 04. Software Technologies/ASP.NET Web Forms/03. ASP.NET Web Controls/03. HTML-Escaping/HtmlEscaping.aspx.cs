using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _03.HTML_Escaping
{
    public partial class HtmlEscaping : System.Web.UI.Page
    {
        protected void btmSubmit_Click(object sender, EventArgs e)
        {
            string inputText = tbInput.Text;

            tbOutput.Text = System.Web.HttpUtility.HtmlEncode(inputText);

            lblOutput.Text = System.Web.HttpUtility.HtmlEncode(inputText);
        }
    }
}