using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _03.PageLifecycle
{
    public partial class PageLifecycle : System.Web.UI.Page
    {
        protected void Page_PreInit(object sender, EventArgs e)
        {
            litOne.Text = litOne.Text + " - PreInit Event";
        }
        protected void Page_Init(object sender, EventArgs e)
        {
            litTwo.Text = litTwo.Text + " - Init Event";
        }
        protected void Page_InitComplete(object sender, EventArgs e)
        {
            litThree.Text = litThree.Text + " - InitComplete Event";
        }
        protected void Page_PreLoad(object sender, EventArgs e)
        {
            litFour.Text = litFour.Text + " - PreLoad Event";
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            litFive.Text = litFive.Text + " - Load Event";
        }
        protected void Page_LoadComplete(object sender, EventArgs e)
        {
            litSix.Text = litSix.Text + " - LoadComplete Event";
        }
        protected void Page_PreRender(object sender, EventArgs e)
        {
            litSeven.Text = litSeven.Text + " - PreRender Event";
        }
        protected void Page_PreRenderComplete(object sender, EventArgs e)
        {
            litEight.Text = litEight.Text + " - PreRenderComplete Event";
        }
        protected void Page_SaveStateComplete(object sender, EventArgs e)
        {
            litNine.Text = litNine.Text + " - SaveStateComplete Event";
        }
    }
}